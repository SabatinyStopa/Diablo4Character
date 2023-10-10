using Diablo4Copy.Managers;
using UnityEngine;

namespace Diablo4Copy.Common
{
    public class OverviewModal : MonoBehaviour
    {
        private int currentId = -1;
        [SerializeField] private GameObject[] descriptionsPanels;

        public void Show(int id)
        {
            currentId = id;

            for (int i = 0; i < descriptionsPanels.Length; i++)
                descriptionsPanels[i].SetActive(i == id);
        }

        public void OnClickClose()
        {
            CharacterSelectionManager.Instance.CanHover = true;
            gameObject.SetActive(false);
        }

        public void OnClickSelect() => CharacterSelectionManager.Instance.OnClickSelect(currentId);
    }
}