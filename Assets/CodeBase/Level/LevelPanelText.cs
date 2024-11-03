using Assets.CodeBase.Scores;
using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.CodeBase.Level
{
    [RequireComponent(typeof(TMP_Text))]
    public class LevelPanelText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        private LevelScores _scores;

        [Inject]
        private void Construct(LevelScores scores)
        {
            _scores = scores;
        }

        private void OnValidate()
        {
            _text ??= GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            _text.text = $"Level complete, you get {_scores.CurrentScores} coins!!!";
        }
    }
}
