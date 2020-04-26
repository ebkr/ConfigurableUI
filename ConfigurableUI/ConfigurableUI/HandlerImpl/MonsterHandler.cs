using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Handlers;
using On.RoR2.UI;
using RoR2;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class MonsterHandler : IHudHandler {
        public void Awake(HUD.orig_Awake orig, RoR2.UI.HUD self) {
            orig(self);
            if (!MonsterConfiguration.ShowHealthOverlay.Value) {
                self.combatHealthBarViewer.enabled = false;
            }
        }
    }
}