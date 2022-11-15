using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Image))]
    public class ImageFade : MonoBehaviour
    {
        private Image image;
        [SerializeField] private bool playOnStart = true;
        [SerializeField] [Range(0, 100)] private float fadeRate = 1f;
        private float targetAlpha;

        protected void Start()
        {
            image = GetComponent<Image>();
            if (!playOnStart) return;
            FadeIn();
        }

        protected void FadeOut()
        {
            targetAlpha = 0f;
            image.raycastTarget = false;
            StartCoroutine(Fade());
        }

        protected void FadeIn()
        {
            targetAlpha = 1f;
            image.raycastTarget = true;
            StartCoroutine(Fade());
        }

        IEnumerator Fade()
        {
            var curColor = image.color;
            while (Mathf.Abs(curColor.a - targetAlpha) > 0.0001f)
            {
                curColor.a = Mathf.Lerp(curColor.a, targetAlpha, fadeRate * Time.deltaTime);
                image.color = curColor;
                yield return null;
            }

            curColor.a = targetAlpha;
            image.color = curColor;
        }
    }
}