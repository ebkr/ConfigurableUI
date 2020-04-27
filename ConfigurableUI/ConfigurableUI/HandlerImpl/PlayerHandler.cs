using System;
using ConfigurableUI.Configs;
using On.RoR2.UI;
using UnityEngine;
using UnityEngine.UI;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class PlayerHandler : BaseHandler {
        public override void RegisterSelfAsAction() {
            HUD.Awake += Awake;
            StageCountDisplay.Update += Update;
            TooltipController.Awake += Awake;
            GenericNotification.Update += Update;
        }

        public override void Awake(HUD.orig_Awake orig, RoR2.UI.HUD self) {
            orig(self);
            
            self.healthBar.transform.parent.gameObject.SetActive(PlayerConfiguration.ShowPlayerStats.Value);
            self.itemInventoryDisplay.gameObject.SetActive(PlayerConfiguration.ShowItems.Value);
            self.objectivePanelController.gameObject.SetActive(PlayerConfiguration.ShowObjectives.Value);
            self.lunarCoinContainer.transform.parent.gameObject.SetActive(PlayerConfiguration.ShowMoney.Value);
            
            // self.mainUIPanel.SetActive(false);
            // self.cinematicPanel.SetActive(false);
            // self.mainContainer.SetActive(false);
            // self.contextManager.contextDisplay.SetActive(false);

            if (!PlayerConfiguration.ShowSkills.Value) {
                for (int i = 0; i < self.skillIcons.Length; i++) {
                    self.skillIcons[i].transform.parent.gameObject.SetActive(false);
                }
            }
        }

        public override void Update(StageCountDisplay.orig_Update orig, RoR2.UI.StageCountDisplay self) {
            orig(self);
            self.transform.parent.gameObject.SetActive(PlayerConfiguration.ShowStageInformation.Value);
        }

        public override void Awake(TooltipController.orig_Awake orig, RoR2.UI.TooltipController self) {
            orig(self);
            self.owner.currentTooltipProvider.enabled = false;
            self.enabled = false;
        }

        public override void Update(GenericNotification.orig_Update orig, RoR2.UI.GenericNotification self) {
            orig(self);
            if (self.transform.GetChild(0)) {
                var image = self.transform.GetChild(0).GetComponent<Image>();
                var color = image.color;
                color.a = (float) PlayerConfiguration.PickupOpacity.Value / 100;
                self.transform.GetChild(0).GetComponent<Image>().color = color;
            }
        }
    }
}