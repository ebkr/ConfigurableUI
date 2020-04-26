using ConfigurableUI.Configs;
using On.RoR2.UI;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class PlayerHandler : BaseHandler {
        public override void RegisterSelfAsAction() {
            HUD.Awake += Awake;
            StageCountDisplay.Update += Update;
        }

        public override void Awake(HUD.orig_Awake orig, RoR2.UI.HUD self) {
            orig(self);
            if (!PlayerConfiguration.ShowPlayerStats.Value) {
                self.healthBar.transform.parent.gameObject.SetActive(false);
            }

            if (!PlayerConfiguration.ShowItems.Value) {
                self.itemInventoryDisplay.gameObject.SetActive(false);
            }

            if (!PlayerConfiguration.ShowObjectives.Value) {
                self.objectivePanelController.gameObject.SetActive(false);
            }

            if (!PlayerConfiguration.ShowMoney.Value) {
                self.lunarCoinContainer.transform.parent.gameObject.SetActive(false);
            }

            if (!PlayerConfiguration.ShowSkills.Value) {
                for (int i = 0; i < self.skillIcons.Length; i++) {
                    self.skillIcons[i].transform.parent.gameObject.SetActive(false);
                }
            }
        }

        public override void Update(StageCountDisplay.orig_Update orig, RoR2.UI.StageCountDisplay self) {
            orig(self);
            if (!PlayerConfiguration.ShowStageInformation.Value) {
                self.transform.parent.gameObject.SetActive(false);
            }
        }

        public override void Awake(BuffDisplay.orig_Awake orig, RoR2.UI.BuffDisplay self) {
            orig(self);
            if (!PlayerConfiguration.ShowBuffs.Value) {
                self.gameObject.SetActive(false);
            }
        }
    }
}