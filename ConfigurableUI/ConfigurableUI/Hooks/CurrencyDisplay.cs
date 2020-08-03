using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Attributes;
using ConfigurableUI.ConfigurableUI.Utils;
using RoR2;
using CostHologramContent = On.RoR2.CostHologramContent;

namespace ConfigurableUI.ConfigurableUI.Hooks {
    public class CurrencyDisplay {
        [ApiHook(typeof(CostHologramContent), "FixedUpdate")]
        public static void ShowPriceBillboard(CostHologramContent.orig_FixedUpdate orig, RoR2.CostHologramContent self) {
            self.transform.parent.gameObject.SetActive(PlayerConfiguration.ShowCosts.Value);
            orig(self);
        }
    }
}