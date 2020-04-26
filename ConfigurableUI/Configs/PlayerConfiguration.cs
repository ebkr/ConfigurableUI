using System;
using BepInEx.Configuration;

namespace ConfigurableUI.Configs {
    public class PlayerConfiguration : IConfigurable {
        
        public static ConfigEntry<bool> ShowPlayerStats;
        public static ConfigEntry<bool> ShowItems;
        
        public void Register(ConfigFile configFile) {
            const String section = "Player";
            ShowPlayerStats = configFile.Bind(new ConfigDefinition(section, "Show health and experience"), true, new ConfigDescription(
                "Allows you to show/hide your health bar and experience bar.",
                new AcceptableValueList<bool>(true, false)));
            ShowItems = configFile.Bind(new ConfigDefinition(section, "Show items at the top of the screen"), true, new ConfigDescription(
                "Allows you to show/hide the list of picked up items.",
                new AcceptableValueList<bool>(true, false)));
        }
    }
}