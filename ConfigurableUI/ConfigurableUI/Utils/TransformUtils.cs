using System;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Utils {
    public class TransformUtils {

        public static Transform findChild(Transform transform, String transformName) {
            for (int i = 0; i < transform.childCount; i++) {
                if (transform.GetChild(i).name.Equals(transformName)) {
                    return transform.GetChild(i);
                }
            }

            return null;
        }
        
    }
}