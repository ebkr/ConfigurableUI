using System;
using BepInEx.Configuration;

namespace ConfigurableUI.Configs {
    public class HoverConfiguration : IConfigurable {
        
        public static ConfigEntry<bool> ShowPickup;
        public static ConfigEntry<int> PickupOpacity;
        public static ConfigEntry<int> PickupBackgroundRed;
        public static ConfigEntry<int> PickupBackgroundGreen;
        public static ConfigEntry<int> PickupBackgroundBlue;
        
        public void Register(ConfigFile configFile) {
            const String section = "Hover UI";
            ShowPickup = configFile.Bind(new ConfigDefinition(section, "Show pickup overlay"), true, new ConfigDescription(
                "Allows you to show/hide the pickup description overlay.",
                new AcceptableValueList<bool>(true, false)));
            PickupOpacity = configFile.Bind(new ConfigDefinition(section, "Configure pickup opacity"), 50, new ConfigDescription(
                "Allows you to toggle the opacity of the pickup description overlay.",
                new AcceptableValueRange<int>(0, 100)));
            PickupBackgroundRed = configFile.Bind(new ConfigDefinition(section, "Pickup colour red (RGB)"), 0, new ConfigDescription(
                "Change the colour of the item pickup overlay.",
                new AcceptableValueRange<int>(0, 255)));
            PickupBackgroundGreen = configFile.Bind(new ConfigDefinition(section, "Pickup colour green (RGB)"), 0, new ConfigDescription(
                "Change the colour of the item pickup overlay.",
                new AcceptableValueRange<int>(0, 255)));
            PickupBackgroundBlue = configFile.Bind(new ConfigDefinition(section, "Pickup colour blue (RGB)"), 0, new ConfigDescription(
                "Change the colour of the item pickup overlay.",
                new AcceptableValueRange<int>(0, 255)));
        }
    }
}