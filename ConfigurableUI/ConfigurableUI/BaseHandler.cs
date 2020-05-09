using ConfigurableUI.ConfigurableUI.Handlers;
using On.LeTai.Asset.TranslucentImage;
using On.RoR2.UI;
using RoR2;
using UnityEngine;
using CharacterBody = RoR2.CharacterBody;
using CostHologramContent = On.RoR2.CostHologramContent;
using RoR2Application = On.RoR2.RoR2Application;
using ShrineBloodBehavior = On.RoR2.ShrineBloodBehavior;
using ShrineBossBehavior = On.RoR2.ShrineBossBehavior;
using ShrineChanceBehavior = On.RoR2.ShrineChanceBehavior;
using ShrineCombatBehavior = On.RoR2.ShrineCombatBehavior;

namespace ConfigurableUI.ConfigurableUI {
    public abstract class BaseHandler : IHudHandler, IPingHandler, IStatsHandler, ICombatHealthBarViewerHandler,
        IStageHandler, ILeTaiHandler, ICrosshairManagerHandler, IShrineHandler {
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

        public virtual void Update(HUDBossHealthBarController.orig_FixedUpdate orig,
            RoR2.UI.HUDBossHealthBarController self) {
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

        public virtual void Update(TranslucentImage.orig_Update orig,
            LeTai.Asset.TranslucentImage.TranslucentImage self) {
            throw new System.NotImplementedException();
        }

        public virtual void Update(HUD.orig_Update orig, RoR2.UI.HUD self) {
            throw new System.NotImplementedException();
        }

        public virtual void StaticLateUpdate(RoR2Application.orig_LateUpdate orig, RoR2.RoR2Application self) {
            throw new System.NotImplementedException();
        }

        public virtual void UpdateCrosshair(CrosshairManager.orig_UpdateCrosshair orig, RoR2.UI.CrosshairManager self,
            CharacterBody targetBody, Vector3 crosshairWorldPosition,
            Camera uiCamera) {
            throw new System.NotImplementedException();
        }

        public virtual void FixedUpdate(CostHologramContent.orig_FixedUpdate orig, RoR2.CostHologramContent self) {
            throw new System.NotImplementedException();
        }

        public virtual void SpawnDamageNumber(On.RoR2.DamageNumberManager.orig_SpawnDamageNumber orig,
            RoR2.DamageNumberManager self,
            float amount,
            Vector3 position,
            bool crit,
            TeamIndex teamIndex,
            DamageColorIndex damageColorIndex) {
            throw new System.NotImplementedException();
        }

        public virtual void FixedUpdate(ShrineCombatBehavior.orig_FixedUpdate orig, RoR2.ShrineCombatBehavior self) {
            throw new System.NotImplementedException();
        }

        public virtual void FixedUpdate(ShrineBloodBehavior.orig_FixedUpdate orig, RoR2.ShrineBloodBehavior self) {
            throw new System.NotImplementedException();
        }

        public virtual void FixedUpdate(ShrineChanceBehavior.orig_FixedUpdate orig, RoR2.ShrineChanceBehavior self) {
            throw new System.NotImplementedException();
        }

        public virtual void FixedUpdate(ShrineBossBehavior.orig_FixedUpdate orig, RoR2.ShrineBossBehavior self) {
            throw new System.NotImplementedException();
        }
    }
}