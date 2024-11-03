using Assets.CodeBase.Level;
using Assets.CodeBase.PocketLogic;
using Assets.CodeBase.Scores;
using Assets.CodeBase.ThrowLogic;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Infrastructure
{
    public class GameplaySceneInstaller : MonoInstaller
    {
        [SerializeField] private LevelScores _scores;
        [SerializeField] private WinPanel _winPanel;
        [SerializeField] private LosePanel _losePanel;
        [SerializeField] private ThrowMovement _player;
        [SerializeField] private List<Fruit> _fruits;
        [SerializeField] private LevelTurn _levelTurn;
        [SerializeField] private ThrowView _throwView;

        public override void InstallBindings()
        {
            Container.Bind<LevelScores>().FromInstance(_scores).NonLazy();
            Container.Bind<WinPanel>().FromInstance(_winPanel).NonLazy();
            Container.Bind<LosePanel>().FromInstance(_losePanel).NonLazy();
            Container.Bind<ThrowMovement>().FromInstance(_player).NonLazy();
            Container.Bind<List<Fruit>>().FromInstance(_fruits).NonLazy();
            Container.Bind<LevelTurn>().FromInstance(_levelTurn).NonLazy();
            Container.Bind<ThrowView>().FromInstance(_throwView).NonLazy();
        }
    }
}