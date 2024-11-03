using UnityEngine;
using Assets.Scripts.Infrastructure.States;

namespace Assets.Scripts.Infrastructure
{
    public class GlobalBootstrap : MonoBehaviour, ICoroutineRunner
    {
        [SerializeField] private LoadingCurtain _loadingCurtaindltlyy;

        private GameStateMachine _gameStateMachinejjtkly;

        public void Awake()
        {
            DontDestroyOnLoad(this);
            _gameStateMachinejjtkly = new(this, _loadingCurtaindltlyy);
            _gameStateMachinejjtkly.Enterekqltr<BootstrapState>();
        }
    }
}
