namespace ConfigurableUI.ConfigurableUI.Handlers {
    public interface IStatsHandler {
        void Awake(On.RoR2.UI.HealthBar.orig_Awake orig, RoR2.UI.HealthBar self);
        void Update(On.RoR2.UI.HealthBar.orig_Update orig, RoR2.UI.HealthBar self);
    }
}