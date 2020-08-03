using System;

// <summary>
//    Allow method to bind to hook automatically on mod load.
// </summary>
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