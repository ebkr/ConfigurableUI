using System;
using System.Linq;
using System.Reflection;
using BepInEx.Logging;
using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Handlers;

namespace ConfigurableUI.ConfigurableUI {
    public class Binder {
        
        private static readonly ManualLogSource LogSource = Logger.CreateLogSource("ConfigurationLogger");
        
        public static void BindHandlers() {
            HandlerBind<IHudHandler>(handler => On.RoR2.UI.HUD.Awake += handler.Awake);
            HandlerBind<IPingHandler>(handler => On.RoR2.UI.PingIndicator.Update += handler.Update);
            HandlerBind<IStatsHandler>(handler => {
                On.RoR2.UI.HealthBar.Update += handler.Update;
                On.RoR2.UI.HealthBar.Awake += handler.Awake;
            });
        }

        private static void HandlerBind<T>(Action<T> action) {
            var handlerClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(T).IsAssignableFrom(type))
                .Where(type => !type.IsAbstract)
                .Select(result => (T) Activator.CreateInstance(result));
            foreach (var handlerClass in handlerClasses) {
                try {
                    action(handlerClass);
                }
                catch (NullReferenceException nre) {
                    LogSource.Log(LogLevel.Error,
                        $"failed to register handler {handlerClass}. \nReason: {nre.ToString()}");
                }
            }
        }
        
    }
}