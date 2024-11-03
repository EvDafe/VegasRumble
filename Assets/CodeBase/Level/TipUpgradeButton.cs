using Assets.CodeBase.ThrowLogic;
using Assets.Scripts.ServicesScripts.Progress;
using Assets.Scripts.ServicesScripts;
using TMPro;
using UnityEngine;
using Zenject;
using UnityEngine.UI;

namespace Assets.CodeBase.Level
{
    [RequireComponent(typeof(Button))]
    public class TipUpgradeButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private TMP_Text _countText;

        private ThrowView _player;
        private LoadProgressService _progress => Services.Containervnfmtk.Geteorpto<LoadProgressService>();

        [Inject]
        private void Construct(ThrowView player)
        {
            _player = player;
        }

        private void OnValidate()
        {
            _button ??= GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
            UpdateText();
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            if (_progress.Progressgkfjtu.StrongAttackCount > 0)
            {
                _player.Upgrade();
                _progress.Progressgkfjtu.TipUpgradeCount--;
                _progress.Saveadlert();
                UpdateText();
            }
        }

        private void UpdateText()
        {
            _countText.text = $"x{_progress.Progressgkfjtu.TipUpgradeCount}";
        }
    }
}
