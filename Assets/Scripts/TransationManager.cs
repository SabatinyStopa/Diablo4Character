using System.Collections;
using UnityEngine.UI;
using UnityEngine;

namespace Diablo4Copy.Managers
{
    public class TransationManager : MonoBehaviour
    {
        [SerializeField] private Image transation;

        private IEnumerator Transaction()
        {
            yield return null;
        }

    }
}