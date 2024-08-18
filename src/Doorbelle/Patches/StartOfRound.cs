using HarmonyLib;
using UnityEngine;

namespace Doorbelle.Patches;

public class StartOfRoundPatch
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(StartOfRound), "TeleportPlayerInShipIfOutOfRoomBounds")]
    public static bool StartOfRoundTPPatch()
    {
        //Plugin.Log.LogInfo("Not TPing player");
        return false;
    }
}