using Diablo4Copy.Common;
using UnityEngine;

namespace Diablo4Copy.Managers
{
    public class CharacterSelectionManager : MonoBehaviour
    {
        public static CharacterSelectionManager Instance;

        [SerializeField] private Transform[] points;
        [SerializeField] private string[] classNames;
        [SerializeField] private Transform[] lightPoints;
        [SerializeField] private Transform lightObj;
        [SerializeField] private SelectionModal selectionModal;
        [SerializeField] private OverviewModal overviewModal;
        [SerializeField] private CustomizationManager costumizationManager;
        [SerializeField] private TransationManager transationManager;

        private bool canHover = true;

        public bool CanHover { get => canHover; set => canHover = value; }

        private void Awake() => Instance = this;

        public void ShowSelectionModal(int id)
        {
            selectionModal.gameObject.SetActive(true);
            selectionModal.SetPosition(points[id].position);
            selectionModal.SetText(classNames[id]);
        }

        public void OnClickOverview(int id)
        {
            canHover = false;
            selectionModal.gameObject.SetActive(false);
            overviewModal.Show(id);
            overviewModal.gameObject.SetActive(true);
        }

        public void OnClickSelect(int id)
        {
            canHover = false;
            CustomizationManager.Select(id);
            selectionModal.gameObject.SetActive(false);
            overviewModal.gameObject.SetActive(false);
            transationManager.PlayTransaction();
        }

        public void OnMouseOverCharacter(int id)
        {
            ShowSelectionModal(id);
            lightObj.gameObject.SetActive(true);
            lightObj.position = lightPoints[id].position;
        }

        public void OnMouseExitCharacter()
        {
            selectionModal.gameObject.SetActive(false);
            lightObj.gameObject.SetActive(false);
        }
    }
}
