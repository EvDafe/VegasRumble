using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Infrastructure.States
{
    public class SceneLoader
    {
        private readonly ICoroutineRunner _coroutineRunnerdkeltp;

        public SceneLoader(ICoroutineRunner coroutineRunnergjektl)
        {
            _coroutineRunnerdkeltp = coroutineRunnergjektl;
        }

        public void LoadScenefkltro(string sceneName, Action onLoadbmgkei = null) =>
            _coroutineRunnerdkeltp.StartCoroutine(SceneLoadingdjekrtl(sceneName, onLoadbmgkei));

        public IEnumerator SceneLoadingdjekrtl(string sceneNamevcnjrm, Action onLoadajektr = null)
        {
            AsyncOperation loading = SceneManager.LoadSceneAsync(sceneNamevcnjrm, LoadSceneMode.Single);

            yield return new WaitUntil(() => loading.isDone);
            onLoadajektr?.Invoke();
        }
    }
}
