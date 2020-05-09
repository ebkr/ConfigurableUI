﻿using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Utils;
using On.RoR2.UI;
using UnityEngine.UI;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class PlayerHandler : BaseHandler {

        public override void RegisterSelfAsAction() {
            HUD.Awake += Awake;
            StageCountDisplay.Update += Update;
            TooltipController.LateUpdate += LateUpdate;
            GenericNotification.Update += Update;
        }

        public override void Awake(HUD.orig_Awake orig, RoR2.UI.HUD self) {
            orig(self);

            var parent = self.healthBar.transform.parent;

            var levelDisplayCluster = TransformUtils.findChild(parent, "LevelDisplayCluster");
            var buffRoot = TransformUtils.findChild(levelDisplayCluster, "BuffDisplayRoot");
            var levelRoot = TransformUtils.findChild(levelDisplayCluster, "LevelDisplayRoot");
            var expBarRoot = TransformUtils.findChild(levelDisplayCluster, "ExpBarRoot");
            
            var healthBarRoot = TransformUtils.findChild(parent, "HealthbarRoot");

            if (!PlayerConfiguration.ShowPlayerStats.Value) {
                parent.GetComponent<Image>().enabled = false;
                levelRoot.gameObject.SetActive(false);
                expBarRoot.gameObject.SetActive(false);
                healthBarRoot.gameObject.SetActive(false);
            }

            RoR2.UI.BuffDisplay buffDisplay = buffRoot.GetComponent<RoR2.UI.BuffDisplay>();
            buffDisplay.gameObject.SetActive(PlayerConfiguration.ShowBuffs.Value);
            
            // self.healthBar.transform.parent.gameObject.SetActive(PlayerConfiguration.ShowPlayerStats.Value);
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

        public override void Update(HUD.orig_Update orig, RoR2.UI.HUD self) {
            orig(self);
            if (self.buffDisplay) {
                self.buffDisplay.gameObject.SetActive(PlayerConfiguration.ShowBuffs.Value);
            }
        }

        public override void Update(StageCountDisplay.orig_Update orig, RoR2.UI.StageCountDisplay self) {
            orig(self);
            self.transform.parent.gameObject.SetActive(PlayerConfiguration.ShowStageInformation.Value);
        }

        public override void LateUpdate(TooltipController.orig_LateUpdate orig, RoR2.UI.TooltipController self) {
            orig(self);
            self.gameObject.SetActive(PlayerConfiguration.ShowItemTooltip.Value);
        }

        public override void Update(GenericNotification.orig_Update orig, RoR2.UI.GenericNotification self) {
            orig(self);
            self.gameObject.SetActive(HoverConfiguration.ShowPickup.Value);
            if (self.transform.GetChild(0)) {
                var image = self.transform.GetChild(0).GetComponent<Image>();
                var color = image.color;
                color.a = (float) HoverConfiguration.PickupOpacity.Value / 100;
                color.r = (float) HoverConfiguration.PickupBackgroundRed.Value / 255;
                color.g = (float) HoverConfiguration.PickupBackgroundGreen.Value / 255;
                color.b = (float) HoverConfiguration.PickupBackgroundBlue.Value / 255;
                self.transform.GetChild(0).GetComponent<Image>().color = color;
            }
        }
    }
}