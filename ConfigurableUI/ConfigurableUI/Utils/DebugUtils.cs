using System;
using System.Linq;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Utils {
    public class DebugUtils {

        public static void prettyPrintAllChildren(Transform transform) {
            _prettyPrintAllChildren(transform, 1);
        }

        private static void _prettyPrintAllChildren(Transform transform, int level) {
            foreach (Transform child in transform) {
                var indent = string.Concat(Enumerable.Repeat("--|", level)) + " ";
                Console.WriteLine(indent + child.name);
                _prettyPrintAllChildren(child, level + 1);
            }
        }
        
    }
}