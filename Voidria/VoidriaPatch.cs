using HarmonyLib;

namespace Voidria
{
  [HarmonyPatch(typeof (Db), "Initialize")]
  public class VoidriaPatch
  {
    public static LocString NAME = (LocString) "Voidria";
    public static LocString DESCRIPTION = (LocString) "Hopeless void. Resources scarced and limited. GEYSERS NOT INCLUDED.\n\nDuplicants MUST work to DEATH to make the colony thrive again.";

    public static void Prefix()
    {
      Strings.Add("STRINGS.WORLDS.VOIDRIA.NAME", (string) VoidriaPatch.NAME);
      Strings.Add("STRINGS.WORLDS.VOIDRIA.DESCRIPTION", (string) VoidriaPatch.DESCRIPTION);
    }
  }
}
