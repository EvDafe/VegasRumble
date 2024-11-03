using Assets.CodeBase.Money;
using Assets.CodeBase.PocketLogic;
using Assets.CodeBase.Scores;
using Assets.CodeBase.ThrowLogic;
using Assets.Scripts.ServicesScripts;
using Assets.Scripts.ServicesScripts.Progress;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Assets.CodeBase.Level
{
    public class LevelTurn : MonoBehaviour
    {
        [SerializeField] private int _hitCount;

        private int _fadeOutCount;
        private int _throwCount;

        private WinPanel _winPanel;
        private LosePanel _losePanel;
        private ThrowMovement _player;
        private List<Fruit> _fruits;
        private LevelScores _scores;

        public int ThrowCount => _throwCount;
        public int HitCount => _hitCount;
        public event Action Throwed;

        [Inject]
        private void Construct(WinPanel winPanel, LosePanel losePanel, ThrowMovement player, List<Fruit> fruits, LevelScores scores)
        {
            _winPanel = winPanel;
            _losePanel = losePanel;
            _player = player;
            _fruits = fruits;
            _scores = scores;
        }

        private void Awake()
        {
            _fruits.ForEach(x => x.FadedOut += OnFadeOut);
            _player.Throwed += OnThrow;
            _winPanel.gameObject.SetActive(false);
            _losePanel.gameObject.SetActive(false);
        }

        private void OnThrow()
        {
            _throwCount++;
            if(_throwCount == _hitCount)
            {
                Lose();
            }
            Throwed?.Invoke();
        }

        private void Lose()
        {
            _losePanel.gameObject.SetActive(true);
        }

        private void OnFadeOut()
        {
            _fadeOutCount++;
            if(_fadeOutCount == _fruits.Count)
            {
                Win();
            }
        }

        private void Win()
        {
            _winPanel.gameObject.SetActive(true);
            Services.Containervnfmtk.Geteorpto<LoadProgressService>().Progressgkfjtu.UnlockedLevelsCountdajijd++;
            Services.Containervnfmtk.Geteorpto<LoadProgressService>().Saveadlert();
            Services.Containervnfmtk.Geteorpto<Wallet>().AddMoneyvmfjri(_scores.CurrentScores);
        }
    }
}
