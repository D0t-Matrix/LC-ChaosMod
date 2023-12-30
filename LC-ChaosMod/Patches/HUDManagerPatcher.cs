using HarmonyLib;

using LC_ChaosMod.Extensions;

namespace LC_ChaosMod.Patches
{
    [HarmonyPatch(typeof(HUDManager))]
    internal class HUDManagerPatcher
    {
        /// <summary>
        /// Patch method when a chat is being sent to the server, to allow us to attach to it.
        /// </summary>
        /// <param name="chatMessage">message being sent to chat</param>
        /// <param name="playerId">ID of player</param>
        [HarmonyPostfix]
        [HarmonyPatch("AddTextToChatOnServer")]
        private static void AddTextToChatOnServer(string chatMessage, int playerId = -1)
        {
            if (playerId <= 0) return;

            var palyerName = ""; 

            Plugin.LogSource.LogInfo($"{palyerName} sent: {chatMessage}");
        }

        [HarmonyPostfix]
        [HarmonyPatch("UseSignalTranslatorServerRpc")]
        private static void UseSignalTranslatorServerRpc(SignalTranslator __instance, string signalMessage)
        {
            if (signalMessage.IsNullOrWhiteSpace()) return;

            Plugin.LogSource.LogInfo($"Signal being transmitted: {signalMessage}");
        }
    }
}
