using Diablo4Copy.Managers;
using UnityEngine;

namespace Diablo4Copy.Common
{
    public class CharacterToSelect : MonoBehaviour
    {
        [SerializeField] private int id;

        private void OnMouseOver()
        {
            if (!CharacterSelectionManager.Instance.CanHover) return;

            CharacterSelectionManager.Instance.OnMouseOverCharacter(id);

            if (Input.GetMouseButtonDown(0)) CharacterSelectionManager.Instance.OnClickSelect(id);
            else if (Input.GetMouseButtonDown(1)) CharacterSelectionManager.Instance.OnClickOverview(id);
        }

        private void OnMouseExit() => CharacterSelectionManager.Instance.OnMouseExitCharacter();
    }
}