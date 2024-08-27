using System;
using MarioMod.Modules;
using MarioMod.Survivors.Mario.Achievements;

namespace MarioMod.Survivors.Mario
{
    public static class MarioTokens
    {
        public static void Init()
        {
            AddHenryTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Henry.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddHenryTokens()
        {
            string prefix = MarioSurvivor.MARIO_PREFIX;

            string desc = "Mario is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Your fists are a good all-rounder." + Environment.NewLine + Environment.NewLine
             + "< ! > Throw fireballs." + Environment.NewLine + Environment.NewLine
             + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine
             + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, searching for a new identity.";
            string outroFailure = "..and so he vanished, forever a blank slate.";

            Language.Add(prefix + "NAME", "Mario");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "The Chosen One");
            Language.Add(prefix + "LORE", "sample lore");
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Luigi");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "Henry passive");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", "Sample text.");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_PUNCH_NAME", "Fists");
            Language.Add(prefix + "PRIMARY_PUNCH_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * MarioStaticValues.hammerDamageCoefficient}% damage</style>.");
            Language.Add(prefix + "PRIMARY_HAMMER_NAME", "Hammer");
            Language.Add(prefix + "PRIMARY_HAMMER_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * MarioStaticValues.hammerDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_GUN_NAME", "Fireball");
            Language.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Tokens.agilePrefix + $"Fire a Fireball for <style=cIsDamage>{100f * MarioStaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            Language.Add(prefix + "UTILITY_ROLL_NAME", "Metal Cap");
            Language.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Dawn the metal cap to <style=cIsUtility> move slower but become invincible</style>  <style=cIsUtility>300 armor</style>.");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_BOMB_NAME", "Lazy Shell");
            Language.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Kick a Shell for <style=cIsDamage>{100f * MarioStaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(MarioMasteryAchievement.identifier), "Henry: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(MarioMasteryAchievement.identifier), "As Henry, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}
