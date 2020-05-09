using System;
using BepInEx.Configuration;

namespace ConfigurableUI.Configs {
    public class MonsterConfiguration : IConfigurable {
        public static ConfigEntry<bool> ShowHealthOverlay;
        public static ConfigEntry<bool> ShowBossHealthBar;
        public static ConfigEntry<bool> ShowDamageNumbers;
        
        public void Register(ConfigFile configFile) {
            const String section = "Monster";
            ShowHealthOverlay = configFile.Bind(new ConfigDefinition(section, "Show monster health"), true, new ConfigDescription(
                "Display the health bar over a monster.",
                new AcceptableValueList<bool>(true, false)));
            ShowBossHealthBar = configFile.Bind(new ConfigDefinition(section, "Show boss health bar"), true, new ConfigDescription(
                "Display the large HUD health bar of a boss.",
                new AcceptableValueList<bool>(true, false)));
            ShowDamageNumbers = configFile.Bind(new ConfigDefinition(section, "Show damage numbers"), true, new ConfigDescription(
                "Show the damage indicator per hit.",
                new AcceptableValueList<bool>(true, false)));
        }
        
    }
}