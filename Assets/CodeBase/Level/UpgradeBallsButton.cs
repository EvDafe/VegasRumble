using Assets.CodeBase.PocketLogic;
using Assets.Scripts.ServicesScripts;
using Assets.Scripts.ServicesScripts.Progress;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.CodeBase.Level
{
    [RequireComponent(typeof(Button))]
    public class UpgradeBallsButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private TMP_Text _countText;

        private List<Fruit> _fruits;
        private LoadProgressService _progress => Services.Containervnfmtk.Geteorpto<LoadProgressService>();

        [Inject]
        private void Construct(List<Fruit> fruits)
        {
            _fruits = fruits;
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
            if(_progress.Progressgkfjtu.MultiplieCount > 0)
            {
                _fruits.ForEach(x => x.Upgrade());
                _progress.Progressgkfjtu.MultiplieCount--;
                _progress.Saveadlert();
                UpdateText();
            }
        }

        private void UpdateText()
        {
            _countText.text = $"x{_progress.Progressgkfjtu.MultiplieCount}";
        }
    }
}
