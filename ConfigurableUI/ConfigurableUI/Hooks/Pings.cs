using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Attributes;
using On.RoR2.UI;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Hooks {
    public class Pings {
        [ApiHook(typeof(PingIndicator), "Update")]
        public static void ShowPingIndicators(PingIndicator.orig_Update orig, RoR2.UI.PingIndicator self) {
            if (!PingConfiguration.ShowPings.Value) {
                foreach (Transform transform in self.transform) {
                    transform.gameObject.SetActive(false);
                }

                foreach (var t in self.defaultPingGameObjects) {
                    t.SetActive(false);
                }

                foreach (GameObject gameObject in self.defaultPingGameObjects) {
                    gameObject.SetActive(false);
                }

                foreach (GameObject gameObject in self.enemyPingGameObjects) {
                    gameObject.SetActive(false);
                }

                foreach (GameObject gameObject in self.interactablePingGameObjects) {
                    gameObject.SetActive(false);
                }
            }

            orig(self);
        }

        [ApiHook(typeof(PingIndicator), "Update")]
        public static void ShowPingHighlights(PingIndicator.orig_Update orig, RoR2.UI.PingIndicator self) {
            self.pingHighlight.enabled = PingConfiguration.ShowPingHighlight.Value;
            orig(self);
        }
    }
}