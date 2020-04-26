using System;
using BepInEx.Configuration;

namespace ConfigurableUI.Configs {
    public class PlayerConfiguration : IConfigurable {
        
        public static ConfigEntry<bool> ShowPlayerStats;
        public static ConfigEntry<bool> ShowItems;
        public static ConfigEntry<bool> ShowObjectives;
        public static ConfigEntry<bool> ShowSkills;
        public static ConfigEntry<bool> ShowMoney;
        public static ConfigEntry<bool> ShowStageInformation;
        public static ConfigEntry<bool> ShowBuffs;
        
        public void Register(ConfigFile configFile) {
            const String section = "Player";
            ShowPlayerStats = configFile.Bind(new ConfigDefinition(section, "Show health and experience"), true, new ConfigDescription(
                "Allows you to show/hide your health bar and experience bar.",
                new AcceptableValueList<bool>(true, false)));
            ShowItems = configFile.Bind(new ConfigDefinition(section, "Show items at the top of the screen"), true, new ConfigDescription(
                "Allows you to show/hide the list of picked up items.",
                new AcceptableValueList<bool>(true, false)));
            ShowObjectives = configFile.Bind(new ConfigDefinition(section, "Show the objectives panel"), true, new ConfigDescription(
                "Allows you to show/hide the objectives panel.",
                new AcceptableValueList<bool>(true, false)));
            ShowSkills = configFile.Bind(new ConfigDefinition(section, "Show skills"), true, new ConfigDescription(
                "Allows you to show/hide the skill bar.",
                new AcceptableValueList<bool>(true, false)));
            ShowMoney = configFile.Bind(new ConfigDefinition(section, "Show the money panel"), true, new ConfigDescription(
                "Allows you to show/hide the money panel containing gold and lunar coins.",
                new AcceptableValueList<bool>(true, false)));
            ShowStageInformation = configFile.Bind(new ConfigDefinition(section, "Show stage information"), true, new ConfigDescription(
                "Allows you to show/hide the stage information panel containing the total time.",
                new AcceptableValueList<bool>(true, false)));
            ShowStageInformation = configFile.Bind(new ConfigDefinition(section, "Show buffs"), true, new ConfigDescription(
                "Allows you to show/hide the player buffs panel.",
                new AcceptableValueList<bool>(true, false)));
        }
    }
}