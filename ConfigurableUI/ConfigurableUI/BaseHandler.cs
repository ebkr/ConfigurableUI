using ConfigurableUI.ConfigurableUI.Handlers;
using On.RoR2.UI;

namespace ConfigurableUI.ConfigurableUI {
    public abstract class BaseHandler : IHudHandler, IPingHandler, IStatsHandler, ICombatHealthBarViewerHandler, IStageHandler {
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

        public virtual void Awake(TooltipController.orig_Awake orig, RoR2.UI.TooltipController self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(GenericNotification.orig_Update orig, RoR2.UI.GenericNotification self) {
            throw new System.NotImplementedException();
        }
    }
}