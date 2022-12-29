using RimWorld;
using UnityEngine;
using Verse;

namespace NoPauseChallenge
{
	public class Settings : ModSettings
	{
		public static bool slowOnRaid = false;
		public static bool slowOnCaravan = false;
		public static bool slowOnLetter = false;
		public static bool slowOnDamage = false;
		public static bool slowOnEnemyApproach = false;
		public static bool slowOnPrisonBreak = false;
		public static bool slowOnAllLetters = true;
		public static bool slowOnPreparedAttack = true;
        public static bool spaceAlwaysSlows = false;
        public static bool ignoreScannedUnderground = false;
        public static bool ignoreInspirations = false;
        public static bool ignoreMisc = false;

        public static void DoSettingsWindowContents(Rect rect)
        {
			Listing_Standard modOptions = new Listing_Standard();

			modOptions.Begin(rect);
			modOptions.Gap(20f);

			_ = modOptions.Label("Events that trigger normal speed");

			modOptions.CheckboxLabeled("Raid", ref slowOnRaid, "Set the game to normal speed when a raid occurs.");
			modOptions.CheckboxLabeled("Caravan", ref slowOnCaravan, "Set the game to normal speed when a Caravan event occurs, such as an ambush.");
			modOptions.CheckboxLabeled("Notification", ref slowOnLetter, "Set the game to normal speed when a certain notifications are received, such as a mad animal.");
			modOptions.CheckboxLabeled("Damage", ref slowOnDamage, "Set the game to normal speed when a pawn takes damage.");
			modOptions.CheckboxLabeled("Enemy Approaching", ref slowOnEnemyApproach, "Set the game to normal speed when an enemy gets near.");
			modOptions.CheckboxLabeled("Prison Break", ref slowOnPrisonBreak, "Set the game to normal speed when a prison break occurs.");

            _ = modOptions.Label("Events that trigger normal speed (Slow On All Letters)");
            modOptions.CheckboxLabeled("All Letters", ref slowOnAllLetters, "Set the game to normal speed when any letter (notification) is received.");
            modOptions.CheckboxLabeled("Prepared Assault", ref slowOnPreparedAttack, "Set the game to normal speed when a 'prepare for a while' raid starts their assault.");
            modOptions.CheckboxLabeled("Spacebar always slows", ref spaceAlwaysSlows, "Set the game to normal speed when spacebar is pressed (normally, the first spacebar slows then the second goes back to your previous speed).");
            modOptions.CheckboxLabeled("Ignore Scanned underground letters", ref ignoreScannedUnderground, "Don't slow the game down when receiving a Scanned underground notification from the Ground Penetrating Scanner.");
            modOptions.CheckboxLabeled("Ignore inspiration letters", ref ignoreInspirations, "Don't slow the game down when a pawn receives an inspiration.");
            modOptions.CheckboxLabeled("Ignore misc letters", ref ignoreMisc, "Don't slow the game down when receiving notifications for Psychic soothe, Eclipse, Aurora, Masterwork, or Gauranlen pod sprout.");

            modOptions.End();
        }

		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Values.Look(ref slowOnRaid, "NPC_SlowOnRaid", false);
			Scribe_Values.Look(ref slowOnCaravan, "NPC_SlowOnCaravan", false);
			Scribe_Values.Look(ref slowOnLetter, "NPC_SlowOnLetter", false);
			Scribe_Values.Look(ref slowOnDamage, "NPC_SlowOnDamage", false);
			Scribe_Values.Look(ref slowOnEnemyApproach, "NPC_SlowOnEnemyApproach", false);
			Scribe_Values.Look(ref slowOnPrisonBreak, "NPC_SlowOnPrisonBreak", false);
            Scribe_Values.Look(ref slowOnAllLetters, "NPC_slowOnAllLetters", true);
            Scribe_Values.Look(ref slowOnPreparedAttack, "NPC_slowOnPreparedAttack", true);
            Scribe_Values.Look(ref spaceAlwaysSlows, "NPC_spaceAlwaysSlows", false);
            Scribe_Values.Look(ref ignoreScannedUnderground, "NPC_ignoreScannedUnderground", false);
            Scribe_Values.Look(ref ignoreInspirations, "NPC_ignoreInspirations", false);
            Scribe_Values.Look(ref ignoreMisc, "NPC_ignoreMisc", false);

        }
    }
}
