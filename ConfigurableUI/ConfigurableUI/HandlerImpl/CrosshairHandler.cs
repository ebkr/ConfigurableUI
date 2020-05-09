using System;
using ConfigurableUI.Configs;
using On.RoR2.UI;
using RoR2;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.HandlerImpl {
    public class CrosshairHandler : BaseHandler {
        public override void RegisterSelfAsAction() {
            CrosshairManager.UpdateCrosshair += UpdateCrosshair;
        }

        public override void UpdateCrosshair(CrosshairManager.orig_UpdateCrosshair orig, RoR2.UI.CrosshairManager self,
            CharacterBody targetBody, Vector3 crosshairWorldPosition,
            Camera uiCamera) {
            orig(self, targetBody, crosshairWorldPosition, uiCamera);
            switch (targetBody.GetDisplayName()) {
                    case "Commando":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.CommandoCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowCommandoCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowCommandoHitmarker.Value);
                        break;
                    case "Huntress":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.HuntressCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowHuntressCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowHuntressHitmarker.Value);
                        break;
                    case "Mercenary":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.MercenaryCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowMercenaryCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowMercenaryHitmarker.Value);
                        break;
                    case "MUL-T":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.MulTCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowMulTCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowMulTHitmarker.Value);
                        break;
                    case "Engineer":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.EngineerCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowEngineerCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowEngineerHitmarker.Value);
                        break;
                    case "Artificer":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.ArtificerCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowArtificerCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowArtificerHitmarker.Value);
                        break;
                    case "REX":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.RexCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowRexCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowRexHitmarker.Value);
                        break;
                    case "Loader":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.LoaderCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowLoaderCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowLoaderHitmarker.Value);
                        break;
                    case "Acrid":
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.AcridCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowAcridCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowAcridHitmarker.Value);
                        break;
                    default:
                        targetBody.crosshairPrefab =
                            getCrosshairPrefabFromValue(CharacterConfiguration.OtherCharacterCrosshair.Value, targetBody);
                        self.container.gameObject.SetActive(CharacterConfiguration.ShowOtherCharacterCrosshair.Value);
                        self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowOtherCharacterHitmarker.Value);
                        break;
                }
        }

        private GameObject getCrosshairPrefabFromValue(string character, CharacterBody targetBody) {
            switch (character) {
                case "commando":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/StandardCrosshair");
                case "huntress":
                case "mercenary":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/SimpleDotCrosshair");
                case "mul-t":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/SMGCrosshair");
                case "engineer":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/EngiCrosshair");
                case "artificer":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/MageCrosshair");
                case "rex":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/TreebotCrosshair");
                case "loader":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/LoaderCrosshair");
                case "acrid":
                    return UnityEngine.Resources.Load<GameObject>("Prefabs/Crosshair/CrocoCrosshair");
                case "default":
                    return targetBody.crosshairPrefab; 
                default:
                    throw new Exception($"Crosshair of character {character} does not exist");
            }
        }
    }
}