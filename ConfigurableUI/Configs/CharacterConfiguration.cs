using System;
using BepInEx.Configuration;

namespace ConfigurableUI.Configs {
    public class CharacterConfiguration : IConfigurable {
        
        public static ConfigEntry<String> CommandoCrosshair;
        public static ConfigEntry<bool> ShowCommandoCrosshair;
        public static ConfigEntry<bool> ShowCommandoHitmarker;
        
        public static ConfigEntry<String> HuntressCrosshair;
        public static ConfigEntry<bool> ShowHuntressCrosshair;
        public static ConfigEntry<bool> ShowHuntressHitmarker;
        
        public static ConfigEntry<String> MulTCrosshair;
        public static ConfigEntry<bool> ShowMulTCrosshair;
        public static ConfigEntry<bool> ShowMulTHitmarker;
        
        public static ConfigEntry<String> EngineerCrosshair;
        public static ConfigEntry<bool> ShowEngineerCrosshair;
        public static ConfigEntry<bool> ShowEngineerHitmarker;
        
        public static ConfigEntry<String> ArtificerCrosshair;
        public static ConfigEntry<bool> ShowArtificerCrosshair;
        public static ConfigEntry<bool> ShowArtificerHitmarker;
        
        public static ConfigEntry<String> MercenaryCrosshair;
        public static ConfigEntry<bool> ShowMercenaryCrosshair;
        public static ConfigEntry<bool> ShowMercenaryHitmarker;
        
        public static ConfigEntry<String> RexCrosshair;
        public static ConfigEntry<bool> ShowRexCrosshair;
        public static ConfigEntry<bool> ShowRexHitmarker;
        
        public static ConfigEntry<String> LoaderCrosshair;
        public static ConfigEntry<bool> ShowLoaderCrosshair;
        public static ConfigEntry<bool> ShowLoaderHitmarker;
        
        public static ConfigEntry<String> AcridCrosshair;
        public static ConfigEntry<bool> ShowAcridCrosshair;
        public static ConfigEntry<bool> ShowAcridHitmarker;
        
        public static ConfigEntry<String> OtherCharacterCrosshair;
        public static ConfigEntry<bool> ShowOtherCharacterCrosshair;
        public static ConfigEntry<bool> ShowOtherCharacterHitmarker;
        

        public void Register(ConfigFile configFile) {
            ShowCommandoCrosshair = configFile.Bind(new ConfigDefinition("Character - Commando", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            CommandoCrosshair = configFile.Bind(new ConfigDefinition("Character - Commando", "Commando crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Commando",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowCommandoHitmarker = configFile.Bind(new ConfigDefinition("Character - Commando", "Show Commando hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowHuntressCrosshair = configFile.Bind(new ConfigDefinition("Character - Huntress", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            HuntressCrosshair = configFile.Bind(new ConfigDefinition("Character - Huntress", "Huntress crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Huntress",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowHuntressHitmarker = configFile.Bind(new ConfigDefinition("Character - Huntress", "Show Huntress hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowMulTCrosshair = configFile.Bind(new ConfigDefinition("Character - MUL-T", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            MulTCrosshair = configFile.Bind(new ConfigDefinition("Character - MUL-T", "MUL-T crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for MUL-T",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowMulTHitmarker = configFile.Bind(new ConfigDefinition("Character - MUL-T", "Show - hitmarkers"), true, new ConfigDescription(
"Show/hide the hitmarker display when successfully hitting a monster",
new AcceptableValueList<bool>(true, false)));
            
            ShowEngineerCrosshair = configFile.Bind(new ConfigDefinition("Character - Engineer", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            EngineerCrosshair = configFile.Bind(new ConfigDefinition("Character - Engineer", "Engineer crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Engineer",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowEngineerHitmarker = configFile.Bind(new ConfigDefinition("Character - Engineer", "Show Engineer hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowArtificerCrosshair = configFile.Bind(new ConfigDefinition("Character - Artificer", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            ArtificerCrosshair = configFile.Bind(new ConfigDefinition("Character - Artificer", "Artificer crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Artificer",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowArtificerHitmarker = configFile.Bind(new ConfigDefinition("Character - Artificer", "Show Artificer hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowMercenaryCrosshair = configFile.Bind(new ConfigDefinition("Character - Mercenary", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            MercenaryCrosshair = configFile.Bind(new ConfigDefinition("Character - Mercenary", "Mercenary crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Mercenary",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowMercenaryHitmarker = configFile.Bind(new ConfigDefinition("Character - Mercenary", "Show Mercenary hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowRexCrosshair = configFile.Bind(new ConfigDefinition("Character - Rex", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            RexCrosshair = configFile.Bind(new ConfigDefinition("Character - Rex", "REX crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for REX",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowRexHitmarker = configFile.Bind(new ConfigDefinition("Character - Rex", "Show REX hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowLoaderCrosshair = configFile.Bind(new ConfigDefinition("Character - Loader", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            LoaderCrosshair = configFile.Bind(new ConfigDefinition("Character - Loader", "Loader crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Loader",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowLoaderHitmarker = configFile.Bind(new ConfigDefinition("Character - Loader", "Show Loader hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowAcridCrosshair = configFile.Bind(new ConfigDefinition("Character - Acrid", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            AcridCrosshair = configFile.Bind(new ConfigDefinition("Character - Acrid", "Acrid crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for Acrid",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowAcridHitmarker = configFile.Bind(new ConfigDefinition("Character - Acrid", "Show Acrid hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
            
            ShowOtherCharacterCrosshair = configFile.Bind(new ConfigDefinition("Character - Other Character", "Enable crosshair"), true, new ConfigDescription(
                "Show/hide the crosshair",
                new AcceptableValueList<bool>(true, false)));
            OtherCharacterCrosshair = configFile.Bind(new ConfigDefinition("Character - Other Character", "Other character crosshair"), "default", new ConfigDescription(
                "Change the crosshair used for any other characters",
                new AcceptableValueList<String>("default", "commando", "huntress", "mul-t", "engineer", "artificer", "mercenary", "rex", "loader", "acrid")));
            ShowOtherCharacterHitmarker = configFile.Bind(new ConfigDefinition("Character - Other Character", "Show hitmarkers"), true, new ConfigDescription(
            "Show/hide the hitmarker display when successfully hitting a monster",
            new AcceptableValueList<bool>(true, false)));
        }
    }
}