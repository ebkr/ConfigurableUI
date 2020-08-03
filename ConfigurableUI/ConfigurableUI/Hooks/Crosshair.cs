using System;
using ConfigurableUI.Configs;
using ConfigurableUI.ConfigurableUI.Attributes;
using On.RoR2.UI;
using RoR2;
using UnityEngine;

namespace ConfigurableUI.ConfigurableUI.Hooks {
    public class Crosshair {
        [ApiHook(typeof(CrosshairManager), "UpdateCrosshair")]
        public static void UpdateCrosshair(CrosshairManager.orig_UpdateCrosshair orig, RoR2.UI.CrosshairManager self,
            CharacterBody targetBody, Vector3 crosshairWorldPosition,
            Camera uiCamera) {
            orig(self, targetBody, crosshairWorldPosition, uiCamera);
            switch (targetBody.GetDisplayName()) {
                case "Commando":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.CommandoCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowCommandoCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowCommandoHitmarker.Value);
                    break;
                case "Huntress":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.HuntressCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowHuntressCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowHuntressHitmarker.Value);
                    break;
                case "Mercenary":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.MercenaryCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowMercenaryCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowMercenaryHitmarker.Value);
                    break;
                case "MUL-T":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.MulTCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowMulTCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowMulTHitmarker.Value);
                    break;
                case "Engineer":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.EngineerCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowEngineerCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowEngineerHitmarker.Value);
                    break;
                case "Artificer":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.ArtificerCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowArtificerCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowArtificerHitmarker.Value);
                    break;
                case "REX":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.RexCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowRexCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowRexHitmarker.Value);
                    break;
                case "Loader":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.LoaderCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowLoaderCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowLoaderHitmarker.Value);
                    break;
                case "Acrid":
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.AcridCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowAcridCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowAcridHitmarker.Value);
                    break;
                default:
                    targetBody.crosshairPrefab =
                        GetCrosshairPrefabFromValue(CharacterConfiguration.OtherCharacterCrosshair.Value, targetBody);
                    self.container.gameObject.SetActive(CharacterConfiguration.ShowOtherCharacterCrosshair.Value);
                    self.hitmarker.gameObject.SetActive(CharacterConfiguration.ShowOtherCharacterHitmarker.Value);
                    break;
            }
        }

        private static GameObject GetCrosshairPrefabFromValue(string character, CharacterBody targetBody) {
            switch (character) {
                case "commando":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/StandardCrosshair");
                case "huntress":
                case "mercenary":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/SimpleDotCrosshair");
                case "mul-t":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/SMGCrosshair");
                case "engineer":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/EngiCrosshair");
                case "artificer":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/MageCrosshair");
                case "rex":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/TreebotCrosshair");
                case "loader":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/LoaderCrosshair");
                case "acrid":
                    return Resources.Load<GameObject>("Prefabs/Crosshair/CrocoCrosshair");
                case "default":
                    return targetBody.crosshairPrefab;
                default:
                    throw new Exception($"Crosshair of character {character} does not exist");
            }
        }
    }
}