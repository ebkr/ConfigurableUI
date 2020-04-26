using System;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace ConfigurableUI.Configs {
    public class MonsterConfiguration : IConfigurable {
        public static ConfigEntry<bool> ShowHealthOverlay;

        public void Register(ConfigFile configFile) {
            const String section = "Monster";
            ShowHealthOverlay = configFile.Bind(new ConfigDefinition(section, "Show monster health"), true, new ConfigDescription(
                "Display the health bar over a monster.",
                new AcceptableValueList<bool>(true, false)));
        }
        
    }
}