using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.CodeBase.Level
{
    [RequireComponent(typeof(TMP_Text))]
    public class HitCountText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        private LevelTurn _levelTurn;

        [Inject]
        private void Construct(LevelTurn levelTurn)
        {
            _levelTurn = levelTurn;
        }

        private void OnValidate()
        {
            _text ??= GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            _levelTurn.Throwed += UpdateText;
            UpdateText();
        }

        private void OnDisable()
        {
            _levelTurn.Throwed -= UpdateText;
        }

        private void UpdateText()
        {
            _text.text = $"{_levelTurn.HitCount - _levelTurn.ThrowCount}/{_levelTurn.HitCount}";
        }
    }
}
