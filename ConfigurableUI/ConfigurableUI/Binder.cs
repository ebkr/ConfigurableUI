using System;
using System.Linq;
using System.Reflection;
using BepInEx.Logging;
using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.HandlerImpl;
using ConfigurableUI.ConfigurableUI.Handlers;

namespace ConfigurableUI.ConfigurableUI {
    public static class Binder {
        private static readonly ManualLogSource LogSource = Logger.CreateLogSource("ConfigurationLogger");

        public static void BindHandlers() {
            var handlerClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(BaseHandler).IsAssignableFrom(type))
                .Where(type => !type.IsAbstract)
                .Select(result => (BaseHandler) Activator.CreateInstance(result));
            foreach (var handlerClass in handlerClasses) {
                handlerClass.RegisterSelfAsAction();
            }
        }
    }
}