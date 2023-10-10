using Diablo4Copy.Effects;
using UnityEngine;

namespace Diablo4Copy.Managers
{
    public class PresetManager : MonoBehaviour
    {
        [SerializeField] private Transform[] presets;
        [SerializeField] private Transform[] presetCharacters;
        [SerializeField] private CustomizationManager customizationManager;
        [SerializeField] private ScreenFade screenFade;

        private Transform currentPreset;

        public void LoadPresetPanel(int id) => presets[id].gameObject.SetActive(true);

        public void OnClickBackButton()
        {
            foreach (Transform preset in presets) preset.gameObject.SetActive(false);
        }

        public void LoadPreset(int id)
        {
            for (int i = 0; i < presetCharacters.Length; i++)
                presetCharacters[i].gameObject.SetActive(i == id);

            currentPreset = presetCharacters[id];
        }

        public void CustomizeCurrent() => StartCoroutine(screenFade.Transition(() => { customizationManager.CustomizeCharacter(currentPreset); }));
    }
}