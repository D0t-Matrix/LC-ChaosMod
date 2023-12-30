using BepInEx;
using BepInEx.Logging;

using HarmonyLib;

namespace LC_ChaosMod
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private readonly Harmony _harmony = new(MyPluginInfo.PLUGIN_GUID);

        internal static RoundManager CurrentRound = RoundManager.Instance;
        internal static ManualLogSource LogSource = BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);
        internal static PluginConfig? PluginConfig { get; private set; }

        //! Plugin startup logic
        public void Awake()
        {

            PluginConfig ??= new(base.Config);
            PluginConfig.InitBindings();

            if (!PluginConfig.Plugin_Enabled)
            {
                LogSource.LogWarning("Chaos Mod loaded, but has been disabled. Not applying patches.");
                return;
            }

            LogSource.LogInfo("Loaded Chaos Mod & applying patches.");
            _harmony.PatchAll(typeof(Plugin).Assembly);
        }

        public void OnDestroy()
        {

        }
    }
}
