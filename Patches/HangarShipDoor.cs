using HarmonyLib;
using UnityEngine;

namespace Doorbelle.Patches;

public class HangarShipDoorPatches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HangarShipDoor), "Start")]
    public static void HangarShipDoorAwakePatch(HangarShipDoor __instance)
    {
        HangerShipDoorAlwaysOpenPatch(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HangarShipDoor), nameof(HangarShipDoor.SetDoorButtonsEnabled))]
    public static void HangerShipDoorAlwaysOpenPatch(HangarShipDoor __instance)
    {
        /*
        string[] OOBTriggers = [
            "Environment/HangarShip/OutOfBounds",
            "Environment/HangarShip/ShipBoundsTrigger",
            "Environment/HangarShip/ShipInnerRoomBoundsTrigger",
            "Environment/OutOfBoundsTrigger1"
            ];
        */

        __instance.buttonsEnabled = true;
        Plugin.Log.LogInfo("Unlocking ship doors");

        /*
        GameObject trigger;

        foreach (string item in OOBTriggers)
        {
            trigger = GameObject.Find(item);

            if (trigger != null)
            {
                Plugin.Log.LogInfo($"Deleting a trigger: {item}");
                GameObject.Destroy(trigger);
            }
        }
        */
    }
}