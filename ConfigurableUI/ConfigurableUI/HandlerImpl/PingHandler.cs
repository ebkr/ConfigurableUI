using ConfigurableUI.Configs;
using On.RoR2.UI;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class PingHandler : BaseHandler {
        public override void RegisterSelfAsAction() {
            PingIndicator.Update += Update;
        }

        public override void Update(PingIndicator.orig_Update orig, RoR2.UI.PingIndicator self) {
            if (!PingConfiguration.ShowPings.Value) {
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
            
            if (!PingConfiguration.ShowPingHighlight.Value) {
                self.pingHighlight.enabled = false;
            }
            orig(self);
        }
    }
}