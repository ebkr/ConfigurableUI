using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Attributes;
using On.RoR2.UI;
using RoR2;
using UnityEngine;
using DamageNumberManager = On.RoR2.DamageNumberManager;

namespace ConfigurableUI.ConfigurableUI.Hooks {
    public class Health {
        [ApiHook(typeof(CombatHealthBarViewer), "Update")]
        public static void MonsterHealthOverlay(CombatHealthBarViewer.orig_Update orig,
            RoR2.UI.CombatHealthBarViewer self) {
            orig(self);
            if (!MonsterConfiguration.ShowHealthOverlay.Value) {
                self.enabled = false;
            }
        }

        [ApiHook(typeof(HUDBossHealthBarController), "FixedUpdate")]
        public static void ShowBossHealthBar(On.RoR2.UI.HUDBossHealthBarController.orig_FixedUpdate orig,
            RoR2.UI.HUDBossHealthBarController self) {
            orig(self);
            if (!MonsterConfiguration.ShowBossHealthBar.Value) {
                self.gameObject.SetActive(false);
            }
        }

        [ApiHook(typeof(DamageNumberManager), "SpawnDamageNumber")]
        public static void ShowDamageNumbers(On.RoR2.DamageNumberManager.orig_SpawnDamageNumber orig,
            RoR2.DamageNumberManager self,
            float amount,
            Vector3 position,
            bool crit,
            TeamIndex teamIndex,
            DamageColorIndex damageColorIndex) {
            if (damageColorIndex != DamageColorIndex.Heal && damageColorIndex != DamageColorIndex.CritHeal) {
                if (!MonsterConfiguration.ShowDamageNumbers.Value) {
                    return;
                }
            }

            orig(self, amount, position, crit, teamIndex, damageColorIndex);
        }
        
        [ApiHook(typeof(DamageNumberManager), "SpawnDamageNumber")]
        public static void ShowHealNumbers(DamageNumberManager.orig_SpawnDamageNumber orig,
            RoR2.DamageNumberManager self,
            float amount,
            Vector3 position,
            bool crit,
            TeamIndex teamIndex,
            DamageColorIndex damageColorIndex) {
            if (damageColorIndex == DamageColorIndex.Heal || damageColorIndex == DamageColorIndex.CritHeal) {
                if (!PlayerConfiguration.ShowHealNumbers.Value) {
                    return;
                }
            }
            orig(self, amount, position, crit, teamIndex, damageColorIndex);
        }
    }
}