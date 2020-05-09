using RoR2;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Handlers {
    public interface IHudHandler {
        void Awake(On.RoR2.UI.HUD.orig_Awake orig, RoR2.UI.HUD self);

        void Update(On.RoR2.UI.HUD.orig_Update orig, RoR2.UI.HUD self);

        void Update(On.RoR2.UI.HUDBossHealthBarController.orig_FixedUpdate orig,
            RoR2.UI.HUDBossHealthBarController self);

        void Awake(On.RoR2.UI.BuffDisplay.orig_Awake orig, RoR2.UI.BuffDisplay self);

        void LateUpdate(On.RoR2.UI.TooltipController.orig_LateUpdate orig, RoR2.UI.TooltipController self);
        
        void Update(On.RoR2.UI.GenericNotification.orig_Update orig, RoR2.UI.GenericNotification self);

        void FixedUpdate(On.RoR2.CostHologramContent.orig_FixedUpdate orig, RoR2.CostHologramContent self);

        void SpawnDamageNumber(On.RoR2.DamageNumberManager.orig_SpawnDamageNumber orig, RoR2.DamageNumberManager self,
            float amount,
            Vector3 position,
            bool crit,
            TeamIndex teamIndex,
            DamageColorIndex damageColorIndex);
    }
}