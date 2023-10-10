using Diablo4Copy.Managers;
using UnityEngine;

namespace Diablo4Copy.Custom
{
    public class CustomizationCharacterSelector : MonoBehaviour
    {
        [SerializeField] private CustomizationManager customizationManager;
        [SerializeField] private int id;

        public void Select() => customizationManager.LoadPresets(id);
    }
}