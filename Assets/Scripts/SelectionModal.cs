using System;
using TMPro;
using UnityEngine;

namespace Diablo4Copy.Common
{
    public class SelectionModal : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI title;

        public void SetPosition(Vector3 position) => transform.position = position;

        public void SetText(string className) => title.text = className;
    }
}