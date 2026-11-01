using HarmonyLib;
using System;
using Verse;

namespace InteractionSpotOnChunk
{
    public class InteractionSpotOnChunk : Mod
    {
        public static ISOCModSettings settings;
        public InteractionSpotOnChunk(ModContentPack content) : base(content)
        {
            settings = GetSettings<ISOCModSettings>();
            new Harmony("dragonissa.InteractionSpotOnChunk").PatchAll();
        }

        public override string SettingsCategory()
        {
            return "Interaction Spot On Chunk";
        }

        public override void DoSettingsWindowContents(UnityEngine.Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            
            listingStandard.CheckboxLabeled("Allow placing on chunks", ref settings.placeOnChunk, "If checked, the interaction spot will be able to be placed on chunks");

            listingStandard.CheckboxLabeled("Allow placing on trees", ref settings.placeOnTree, "If checked, the interaction spot will be able to be placed on trees");

            listingStandard.GapLine();

            listingStandard.CheckboxLabeled("Debug Mode", ref settings.debugMode, "If checked, debug messages will be logged to the console.");

            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }
    }
}
