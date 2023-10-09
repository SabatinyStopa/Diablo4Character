using Diablo4Copy.Managers;
using UnityEngine;

namespace Diablo4Copy.Common
{
    public class CharacterToSelect : MonoBehaviour
    {
        [SerializeField] private int id;

        private void OnMouseOver() => CharacterSelectionManager.Instance.OnMouseOverCharacter(id);

        private void OnMouseExit() => CharacterSelectionManager.Instance.OnMouseExitCharacter();
    }
}