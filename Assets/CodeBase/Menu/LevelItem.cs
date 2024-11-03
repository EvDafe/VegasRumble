using Assets.Scripts.Infrastructure.States;
using Assets.Scripts.ServicesScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.CodeBase.Menu
{
    public class LevelItem : MonoBehaviour
    {
        [SerializeField] private Button _buttonqifjtk;
        [SerializeField] private TMP_Text _numberTextbngjtk;
        [SerializeField] private Image _BGavdgfh;
        [SerializeField] private Color _unlockedColortughdm;
        [SerializeField] private Color _lockedColorvborti;

        public int IDqotlrk;

        public void SetNumberajekrl(int iddqdqll)
        {
            IDqotlrk = iddqdqll;
            _numberTextbngjtk.text = IDqotlrk.ToString();
        }

        public void Lockvmgjek()
        {
            _buttonqifjtk.onClick.RemoveAllListeners();
            _BGavdgfh.color = _lockedColorvborti;
        }

        public void Unlockfhdjsk()
        {
            _buttonqifjtk.onClick.RemoveAllListeners();
            _BGavdgfh.color = _unlockedColortughdm;
            _buttonqifjtk.onClick.AddListener(LoadScenekojoho);
        }

        private void LoadScenekojoho()
        {
            Services.Containervnfmtk.Geteorpto<SceneLoadService>().LoadSceneejlsir<GameLoopState>(IDqotlrk.ToString());
        }
    }
}
