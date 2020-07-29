using System;

namespace ConfigurableUI.ConfigurableUI.Attributes {
    public class ApiHook : Attribute {
        public Type HookOrigin { get; }
        public string HookedEventName { get; }

        public ApiHook(Type hookOrigin, string hookedEventName) {
            HookOrigin = hookOrigin;
            HookedEventName = hookedEventName;
        }
    }
}