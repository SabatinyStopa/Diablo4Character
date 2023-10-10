using UnityEngine;

namespace Diablo4Copy.Managers
{
    public class CustomizationManager : MonoBehaviour
    {
        private static int id;

        [SerializeField] private PresetManager presetManager;
        [SerializeField] private Transform customizationPoint;
        [SerializeField] private GameObject customizationCanvas;
        [SerializeField] private Transform cameraPosition;

        public static void Select(int id) => CustomizationManager.id = id;
        public void LoadPresets(int id) => presetManager.LoadPresetPanel(id);
        public void OnClickBackButton() => presetManager.OnClickBackButton();

        public void CustomizeCharacter(Transform characterToCustomize)
        {
            Camera.main.transform.position = cameraPosition.position;
            Camera.main.transform.rotation = cameraPosition.rotation;
            Instantiate(characterToCustomize, customizationPoint.position, Quaternion.identity);
            customizationCanvas.SetActive(true);
        }
    }
}