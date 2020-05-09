using ConfigurableUI.ConfigurableUI.Utils;
using On.RoR2;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class ShrineHandler : BaseHandler {
        public override void RegisterSelfAsAction() {
            ShrineCombatBehavior.FixedUpdate += FixedUpdate;
            ShrineBloodBehavior.FixedUpdate += FixedUpdate;
            ShrineChanceBehavior.FixedUpdate += FixedUpdate;
            ShrineBossBehavior.FixedUpdate += FixedUpdate;
        }

        public override void FixedUpdate(ShrineCombatBehavior.orig_FixedUpdate orig, RoR2.ShrineCombatBehavior self) {
            orig(self);
            var shrineBase = TransformUtils.findChild(self.transform, "Base");
            var decal = TransformUtils.findChild(shrineBase, "Decal");
            decal.gameObject.SetActive(false);
        }

        public override void FixedUpdate(ShrineBloodBehavior.orig_FixedUpdate orig, RoR2.ShrineBloodBehavior self) {
            orig(self);
            /**
             * HologramPivot
             * Symbol
             * Base
             */
            var shrineBase = TransformUtils.findChild(self.transform, "Base");
            var decal = TransformUtils.findChild(shrineBase, "Decal");
            decal.gameObject.SetActive(false);
        }

        public override void FixedUpdate(ShrineChanceBehavior.orig_FixedUpdate orig, RoR2.ShrineChanceBehavior self) {
            orig(self);
            var shrineBase = TransformUtils.findChild(self.transform, "Base");
            var decal = TransformUtils.findChild(shrineBase, "Decal");
            decal.gameObject.SetActive(false);
        }

        public override void FixedUpdate(ShrineBossBehavior.orig_FixedUpdate orig, RoR2.ShrineBossBehavior self) {
            orig(self);
            var shrineBase = TransformUtils.findChild(self.transform, "Base");
            var decal = TransformUtils.findChild(shrineBase, "Decal");
            decal.gameObject.SetActive(false);
        }
    }
}