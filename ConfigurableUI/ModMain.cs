using System;
using BepInEx;
using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI;

namespace ConfigurableUI {
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("mod.ebkr.configurable_ui", "ConfigurableUI", "1.0.0")]
    public class ModMain : BaseUnityPlugin {
        public void Awake() {
            Configurations.Initialise();
            Binder.BindHandlers();
        }
    }
}