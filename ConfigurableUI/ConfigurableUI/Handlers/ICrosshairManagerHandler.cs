using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Handlers {
    public interface ICrosshairManagerHandler {
        void StaticLateUpdate(On.RoR2.RoR2Application.orig_LateUpdate orig, RoR2.RoR2Application self);

        void UpdateCrosshair(
            On.RoR2.UI.CrosshairManager.orig_UpdateCrosshair orig,
            RoR2.UI.CrosshairManager self,
            RoR2.CharacterBody targetBody,
            Vector3 crosshairWorldPosition,
            Camera uiCamera);
    }
}