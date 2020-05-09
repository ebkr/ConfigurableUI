namespace ConfigurableUI.ConfigurableUI.Handlers {
    public interface IShrineHandler {

        void FixedUpdate(On.RoR2.ShrineCombatBehavior.orig_FixedUpdate orig, RoR2.ShrineCombatBehavior self);
        void FixedUpdate(On.RoR2.ShrineBloodBehavior.orig_FixedUpdate orig, RoR2.ShrineBloodBehavior self);
        void FixedUpdate(On.RoR2.ShrineChanceBehavior.orig_FixedUpdate orig, RoR2.ShrineChanceBehavior self);
        void FixedUpdate(On.RoR2.ShrineBossBehavior.orig_FixedUpdate orig, RoR2.ShrineBossBehavior self);

    }
}