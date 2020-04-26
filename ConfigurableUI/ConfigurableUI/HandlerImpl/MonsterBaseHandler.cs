using ConfigurableUI.Configs;
using On.RoR2.UI;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class MonsterBaseHandler : BaseHandler {
        
        public override void RegisterSelfAsAction() {
            CombatHealthBarViewer.Update += Update;
            HUDBossHealthBarController.FixedUpdate += Update;
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
    }
}