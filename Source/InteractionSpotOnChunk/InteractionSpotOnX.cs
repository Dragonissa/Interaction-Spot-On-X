using HarmonyLib;
using System;
using Verse;

namespace InteractionSpotOnX
{
    public class InteractionSpotOnX : Mod
    {
        public static ISOXModSettings settings;
        public InteractionSpotOnX(ModContentPack content) : base(content)
        {
            settings = GetSettings<ISOXModSettings>();
            new Harmony("dragonissa.InteractionSpotOnX").PatchAll();
        }

        public override string SettingsCategory()
        {
            return "Interaction Spot On X";
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
