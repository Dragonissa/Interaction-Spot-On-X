using Verse;

namespace InteractionSpotOnChunk
{
    public class ISOCModSettings : ModSettings
    {
        public bool debugMode = false;
        public bool placeOnChunk = true;
        public bool placeOnTree = false;
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref debugMode, "debugMode", false);
            Scribe_Values.Look(ref placeOnChunk, "placeOnChunk", true);
            Scribe_Values.Look(ref placeOnTree, "placeOnTree", false);
        }
    }
}
