using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Infrastructure
{
    public class LoadingCurtain : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _curtainmfkrej;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            Hidedajerk();
        }

        public void Showfnjtky()
        {
            _curtainmfkrej.gameObject.SetActive(true);
            _curtainmfkrej.alpha = 1;
        }

        public void Hidedajerk() => 
            StartCoroutine(FadeInadntmy());

        private IEnumerator FadeInadntmy()
        {
            while(_curtainmfkrej.alpha > 0)
            {
                yield return new WaitForSeconds(0.03f);
                _curtainmfkrej.alpha -= 0.03f;
            }
            _curtainmfkrej.gameObject.SetActive(false);
        }
    }
}
