using System;
using System.Collections;
using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Handlers;
using On.RoR2.UI;
using UnityEngine;
using UnityEngine.UI;
using Console = RoR2.Console;
using Object = UnityEngine.Object;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class PlayerHandler : IHudHandler {

        public void Update(On.RoR2.UI.HealthBar.orig_Update orig, RoR2.UI.HealthBar self) {
            orig(self);
        }

        public void Awake(HUD.orig_Awake orig, RoR2.UI.HUD self) {
            orig(self);
            if (!PlayerConfiguration.ShowPlayerStats.Value) {
                self.healthBar.transform.parent.gameObject.SetActive(false);
            }
            if (!PlayerConfiguration.ShowItems.Value) {
                self.itemInventoryDisplay.transform.parent.gameObject.SetActive(false);
            }
        }
    }
}