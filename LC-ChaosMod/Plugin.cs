using BepInEx;
using BepInEx.Logging;

using HarmonyLib;

namespace LC_ChaosMod
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static bool loaded;
        public static ManualLogSource? LogSource;
        private readonly Harmony _harmony = new(MyPluginInfo.PLUGIN_GUID);

        internal static ManualLogSource LogSource = BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);
        //! Plugin startup logic
        public void Awake()
        {
            LogSource = BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);

            LogSource.LogInfo("Loaded Chaos Mod & applying patches.");
            _harmony.PatchAll(typeof(Plugin).Assembly);
        }
    }
}
