using System;
using System.Linq;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Utils {
    public static class DebugUtils {

        public static void PrettyPrintAllChildren(Transform transform) {
            PrettyPrintAllChildren(transform, 1);
        }

        private static void PrettyPrintAllChildren(Transform transform, int level) {
            foreach (Transform child in transform) {
                var indent = string.Concat(Enumerable.Repeat("--|", level)) + " ";
                Console.WriteLine(indent + child.name);
                PrettyPrintAllChildren(child, level + 1);
            }
        }
        
    }
}