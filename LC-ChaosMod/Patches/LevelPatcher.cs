using HarmonyLib;

namespace LC_ChaosMod.Patches
{
    [HarmonyPatch(typeof(RoundManager))]
    internal class LevelPatcher
    {
        [HarmonyPostfix]
        [HarmonyPatch("LoadNewLevel")]
        static void LoadNewLevel()
        {
            Plugin.CurrentRound = RoundManager.Instance;
        }

        [HarmonyPostfix]
        [HarmonyPatch("FinishGeneratingNewLevelClientRpc")]
        static void FinishGeneratingNewLevelClientRpcPatch()
        {
        }
    }
}
