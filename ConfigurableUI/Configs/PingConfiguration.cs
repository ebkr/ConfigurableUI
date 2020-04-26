using System;
using BepInEx.Configuration;
using UnityEngine;

namespace ConfigurableUI.Configs {
    public class PingConfiguration : IConfigurable {
        
        public static ConfigEntry<bool> ShowPings;
        public static ConfigEntry<bool> ShowPingHighlight;
        
        public void Register(ConfigFile configFile) {
            const String section = "General";
            ShowPings = configFile.Bind(new ConfigDefinition(section, "Show pings"), true, new ConfigDescription(
                "Enable/disable ping visibility.",
                new AcceptableValueList<bool>(true, false)));
            ShowPingHighlight = configFile.Bind(section, "Show ping highlights", true, new ConfigDescription(
                "Enable/disable ping highlights.",
                new AcceptableValueList<bool>(true, false)));
        }
    }
}