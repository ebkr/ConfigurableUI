using System;
using System.Collections;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

namespace ConfigurableUI.Configs {
    public class Configurations {
        private static ManualLogSource _logSource;
        private static ConfigFile _configFile;
        
        public static void Initialise() {
            _configFile = new ConfigFile(Paths.ConfigPath + "\\ConfigurableUI.cfg", true);
            _logSource = Logger.CreateLogSource("ConfigurationLogger");
            RunConfigurables();
        }

        private static void RunConfigurables() {
            var configurableClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(IConfigurable).IsAssignableFrom(type))
                .Where(type => !type.IsAbstract)
                .Select(result => Activator.CreateInstance(result) as IConfigurable);
            foreach (var configurableClass in configurableClasses) {
                try {
                    configurableClass.Register(_configFile);
                }
                catch (NullReferenceException nre) {
                    _logSource.Log(LogLevel.Error,
                        $"failed to register configuration {configurableClass}. \nReason: {nre.ToString()}");
                }
            }
        }
    }

    public interface IConfigurable {
        void Register(ConfigFile configFile);
    }
}