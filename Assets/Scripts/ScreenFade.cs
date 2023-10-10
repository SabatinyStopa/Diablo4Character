using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Diablo4Copy.Effects
{
    public class ScreenFade : MonoBehaviour
    {
        [SerializeField] private Image imageToFade;

        public IEnumerator Transition(Action onEnd = null)
        {
            imageToFade.gameObject.SetActive(true);
            yield return FadeToFullAlpha();
            yield return FadeToZeroAlpha();
            imageToFade.gameObject.SetActive(false);

            onEnd?.Invoke();
        }

        private IEnumerator FadeToFullAlpha()
        {
            var alpha = 0f;

            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, alpha);

            while (alpha < 1)
            {
                imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, alpha);
                alpha += Time.deltaTime * 5;
                yield return null;
            }
        }

        private IEnumerator FadeToZeroAlpha()
        {
            var alpha = 1f;

            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, alpha);

            while (alpha > 0)
            {
                imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, alpha);
                alpha -= Time.deltaTime * 5;
                yield return null;
            }
        }
    }
}