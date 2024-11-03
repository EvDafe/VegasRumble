using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.CodeBase.Scores
{
    public class ScoreText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private LevelScores _scores;

        [Inject]
        private void Construct(LevelScores levelScores)
        {
            _scores = levelScores;
        }

        private void OnEnable()
        {
            _text.text = _scores.CurrentScores.ToString();
            _scores.ScoresUpdated += UpdateText;
        }

        private void OnDisable()
        {
            _scores.ScoresUpdated -= UpdateText;
        }

        private void UpdateText()
        {
            _text.text = _scores.CurrentScores.ToString();
        }
    }
}
