using System;
using System.Linq;
using System.Linq.Expressions;
using BepInEx.Logging;
using ConfigurableUI.ConfigurableUI.Attributes;
using MonoMod.Utils;

namespace ConfigurableUI.ConfigurableUI {
    public static class Binder {
        private static readonly ManualLogSource LogSource = Logger.CreateLogSource("ConfigurationLogger");

        private static readonly object BindingObject = new object();

        public static void BindHandlers() {
            var methods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods())
                .Where(info => info.GetCustomAttributes(typeof(ApiHook), false).Length > 0)
                .ToArray();
            foreach (var methodInfo in methods) {
                Console.WriteLine($"Binding {methodInfo}");
                foreach (ApiHook customAttribute in methodInfo.GetCustomAttributes(typeof(ApiHook), false)) {
                    var hookEvent = customAttribute.HookOrigin.GetEvent(customAttribute.HookedEventName);
                    var delegatedMethod = Delegate.CreateDelegate(hookEvent.EventHandlerType, methodInfo);
                    hookEvent.AddEventHandler(BindingObject, delegatedMethod);
                }
            }
        }
    }
}