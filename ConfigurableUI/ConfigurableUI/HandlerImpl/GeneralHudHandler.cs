using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Handlers;
using On.RoR2.UI;
using R2API.Utils;
using RoR2;
using UnityEngine;
using Console = System.Console;
using Object = UnityEngine.Object;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class GeneralHudHandler : IPingHandler {
        public void Update(PingIndicator.orig_Update orig, RoR2.UI.PingIndicator self) {
            if (!GeneralHudConfiguration.ShowPings.Value) {
                foreach (Transform transform in self.transform) {
                    transform.gameObject.SetActive(false);
                }
                for (int i = 0; i < self.defaultPingGameObjects.Length; i++) {
                    self.defaultPingGameObjects[i].SetActive(false);
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
            
            if (!GeneralHudConfiguration.ShowPingHighlight.Value) {
                self.pingHighlight.enabled = false;
            }
            orig(self);
        }
    }
}