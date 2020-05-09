using ConfigurableUI.ConfigurableUI.Handlers;
using On.LeTai.Asset.TranslucentImage;
using On.RoR2;
using On.RoR2.UI;
using UnityEngine;
using CharacterBody = RoR2.CharacterBody;

namespace ConfigurableUI.ConfigurableUI {
    public abstract class BaseHandler : IHudHandler, IPingHandler, IStatsHandler, ICombatHealthBarViewerHandler, IStageHandler, ILeTaiHandler, ICrosshairManagerHandler {
        public abstract void RegisterSelfAsAction();

        public virtual void Awake(HUD.orig_Awake orig, RoR2.UI.HUD self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(CombatHealthBarViewer.orig_Update orig, RoR2.UI.CombatHealthBarViewer self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(PingIndicator.orig_Update orig, RoR2.UI.PingIndicator self) {
            throw new System.NotImplementedException();
        }

        public virtual void Awake(HealthBar.orig_Awake orig, RoR2.UI.HealthBar self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(HealthBar.orig_Update orig, RoR2.UI.HealthBar self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(HUDBossHealthBarController.orig_FixedUpdate orig, RoR2.UI.HUDBossHealthBarController self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(StageCountDisplay.orig_Update orig, RoR2.UI.StageCountDisplay self) {
            throw new System.NotImplementedException();
        }

        public virtual void Awake(BuffDisplay.orig_Awake orig, RoR2.UI.BuffDisplay self) {
            throw new System.NotImplementedException();
        }

        public virtual void LateUpdate(TooltipController.orig_LateUpdate orig, RoR2.UI.TooltipController self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(GenericNotification.orig_Update orig, RoR2.UI.GenericNotification self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(TranslucentImage.orig_Update orig, LeTai.Asset.TranslucentImage.TranslucentImage self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(HUD.orig_Update orig, RoR2.UI.HUD self) {
            throw new System.NotImplementedException();
        }

        public virtual void StaticLateUpdate(RoR2Application.orig_LateUpdate orig, RoR2.RoR2Application self) {
            throw new System.NotImplementedException();
        }

        public virtual void UpdateCrosshair(CrosshairManager.orig_UpdateCrosshair orig, RoR2.UI.CrosshairManager self, CharacterBody targetBody, Vector3 crosshairWorldPosition,
            Camera uiCamera) {
            throw new System.NotImplementedException();
        }
    }
}