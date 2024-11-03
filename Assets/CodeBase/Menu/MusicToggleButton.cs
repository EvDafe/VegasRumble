using Assets.Scripts.ServicesScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.CodeBase.Player
{
    public class MusicToggleButton : MonoBehaviour
    {
        [SerializeField] private Button _buttondkaopf;

        private void OnEnable()
        {
            Debug.Log("Enable");
            _buttondkaopf = GetComponent<Button>();
            _buttondkaopf.onClick.AddListener(OnClickkdoapd);
        }

        private void OnDisable()
        {
            _buttondkaopf.onClick.RemoveListener(OnClickkdoapd);
        }

        private void OnClickkdoapd()
        {
            Debug.Log("Click");
            Services.Containervnfmtk.Geteorpto<SoundsManager>().ToggleMusicdaldp(); 
        }
    }
}
