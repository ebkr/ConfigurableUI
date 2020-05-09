using ConfigurableUI.Configs;
using On.RoR2.UI;
using RoR2;
using UnityEngine;
using DamageNumberManager = On.RoR2.DamageNumberManager;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class MonsterBaseHandler : BaseHandler {
        
        public override void RegisterSelfAsAction() {
            CombatHealthBarViewer.Update += Update;
            HUDBossHealthBarController.FixedUpdate += Update;
            DamageNumberManager.SpawnDamageNumber += SpawnDamageNumber;
        }

        public override void Update(On.RoR2.UI.CombatHealthBarViewer.orig_Update orig, RoR2.UI.CombatHealthBarViewer self) {
            orig(self);
            if (!MonsterConfiguration.ShowHealthOverlay.Value) {
                self.enabled = false;
            }
        }

        public override void Update(On.RoR2.UI.HUDBossHealthBarController.orig_FixedUpdate orig, RoR2.UI.HUDBossHealthBarController self) {
            orig(self);
            if (!MonsterConfiguration.ShowBossHealthBar.Value) {
                self.gameObject.SetActive(false);
            }
        }
        
        public override void SpawnDamageNumber(On.RoR2.DamageNumberManager.orig_SpawnDamageNumber orig,
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
    }
}