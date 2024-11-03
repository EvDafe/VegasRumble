using Assets.Scripts.Infrastructure.States;
using Assets.Scripts.ServicesScripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.CodeBase.Level
{
    [RequireComponent(typeof(Button))]
    public class RestartLevelButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private void OnValidate()
        {
            _button ??= GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            Services.Containervnfmtk.Geteorpto<SceneLoadService>().LoadSceneejlsir<GameLoopState>(SceneManager.GetActiveScene().name);
        }
    }
}
