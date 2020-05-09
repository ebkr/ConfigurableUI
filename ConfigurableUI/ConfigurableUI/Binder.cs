using System;
using System.Linq;
using BepInEx.Logging;

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