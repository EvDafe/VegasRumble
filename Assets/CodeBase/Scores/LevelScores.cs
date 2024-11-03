using System;
using UnityEngine;

namespace Assets.CodeBase.Scores
{
    public class LevelScores : MonoBehaviour
    {
        private int _currentScores;

        public event Action ScoresUpdated;
        public int CurrentScores => _currentScores;

        public void AddScores(int scores)
        {
            _currentScores += scores;
            ScoresUpdated?.Invoke();
        }
    }
}
