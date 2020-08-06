using System;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Utils {
    public static class TransformUtils {

        public static Transform FindChild(Transform transform, String transformName) {
            for (var i = 0; i < transform.childCount; i++) {
                if (transform.GetChild(i).name.Equals(transformName)) {
                    return transform.GetChild(i);
                }
            }

            return null;
        }
        
    }
}