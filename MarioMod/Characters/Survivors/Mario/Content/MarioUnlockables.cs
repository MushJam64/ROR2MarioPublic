using MarioMod.Survivors.Mario.Achievements;
using RoR2;
using UnityEngine;

namespace MarioMod.Survivors.Mario
{
    public static class MarioUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                MarioMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(MarioMasteryAchievement.identifier),
                MarioSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
