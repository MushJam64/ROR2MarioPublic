using RoR2;
using MarioMod.Modules.Achievements;

namespace MarioMod.Survivors.Mario.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, null)]
    public class MarioMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = MarioSurvivor.MARIO_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = MarioSurvivor.MARIO_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => MarioSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}