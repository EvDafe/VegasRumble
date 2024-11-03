using Assets.Scripts.ServicesScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.CodeBase.Player
{
    public class SoundsToggleButton : MonoBehaviour
    {
        [SerializeField] private Button _buttonqetyhg;

        private void OnEnable()
        {
            Debug.Log("Enable");
            _buttonqetyhg = GetComponent<Button>();
            _buttonqetyhg.onClick.AddListener(OnClickdkafog);
        }

        private void OnDisable()
        {
            _buttonqetyhg.onClick.RemoveListener(OnClickdkafog);
        }

        private void OnClickdkafog()
        {
            Debug.Log("Click");
            Services.Containervnfmtk.Geteorpto<SoundsManager>().ToggleSoundiqeqeo();
        }
    }
}
