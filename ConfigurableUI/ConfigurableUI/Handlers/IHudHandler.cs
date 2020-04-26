namespace ConfigurableUI.ConfigurableUI.Handlers {
    public interface IHudHandler {
        void Awake(On.RoR2.UI.HUD.orig_Awake orig, RoR2.UI.HUD self);

        void Update(On.RoR2.UI.HUDBossHealthBarController.orig_FixedUpdate orig,
            RoR2.UI.HUDBossHealthBarController self);

        void Awake(On.RoR2.UI.BuffDisplay.orig_Awake orig, RoR2.UI.BuffDisplay self);
    }
}