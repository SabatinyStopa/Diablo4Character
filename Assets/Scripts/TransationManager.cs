using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

namespace Diablo4Copy.Managers
{
    public class TransationManager : MonoBehaviour
    {
        [Header("Camera")]
        [SerializeField] private Transform cameraToMove;
        [SerializeField] private Transform finalPosition;
        [SerializeField] private float speed = 2;
        [Header("Transation")]
        [SerializeField] private Image transation;
        [SerializeField] private string sceneToLoad = "CostumizationScene";

        public void PlayTransaction() => StartCoroutine(Transaction());

        private IEnumerator AnimateCamera()
        {
            while (Vector3.Distance(cameraToMove.position, finalPosition.position) > 0.02)
            {
                cameraToMove.position = Vector3.MoveTowards(cameraToMove.position, finalPosition.position, speed * Time.deltaTime);
                yield return null;
            }

        }

        private IEnumerator Transaction()
        {
            yield return AnimateCamera();

            var alpha = 0f;

            transation.gameObject.SetActive(true);
            transation.color = new Color(transation.color.r, transation.color.g, transation.color.b, 0);

            while (alpha < 1)
            {
                alpha += Time.deltaTime;
                yield return null;
                transation.color = new Color(transation.color.r, transation.color.g, transation.color.b, alpha);
            }

            StartCoroutine(LoadScene());
        }

        private IEnumerator LoadScene()
        {
            yield return null;
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
            asyncOperation.allowSceneActivation = false;

            while (!asyncOperation.isDone)
            {
                yield return null;

                if (asyncOperation.progress >= 0.9f)
                    asyncOperation.allowSceneActivation = true;
            }
        }
    }
}