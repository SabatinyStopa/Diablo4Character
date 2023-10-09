using Diablo4Copy.Common;
using UnityEngine;

namespace Diablo4Copy.Managers
{
    public class CharacterSelectionManager : MonoBehaviour
    {
        public static CharacterSelectionManager Instance;

        [SerializeField] private Transform[] points;
        [SerializeField] private string[] classNames;
        [SerializeField] private SelectionModal selectionModal;
        [SerializeField] private OverviewModal overviewModal;
        [SerializeField] private CostumizationManager costumizationManager;

        private void Awake() => Instance = this;

        public void ShowSelectionModal(int id)
        {
            selectionModal.gameObject.SetActive(true);
            selectionModal.SetPosition(points[id].position);
            selectionModal.SetText(classNames[id]);
        }

        public void OnClickOverview(int id)
        {
            overviewModal.Show(id);
            overviewModal.gameObject.SetActive(true);
        }

        public void OnClickSelect(int id) => costumizationManager.Select(id);

        public void OnMouseOverCharacter(int id) => ShowSelectionModal(id);

        public void OnMouseExitCharacter() => selectionModal.gameObject.SetActive(false);
    }
}
