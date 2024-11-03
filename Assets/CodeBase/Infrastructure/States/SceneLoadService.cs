using Assets.Scripts.ServicesScripts;
using System;

namespace Assets.Scripts.Infrastructure.States
{
    public class SceneLoadService : IService
    {
        private readonly GameStateMachine _gameStateMachine;

        public SceneLoadService(GameStateMachine gameStateMachine) =>
            _gameStateMachine = gameStateMachine;

        public void LoadSceneejlsir<TNextState>(string sceneName, Action onLoad = null) where TNextState : class, IState
        {
            IExitableState state = _gameStateMachine.GetStateemtkui<LoadSceneState>();
            var loadingState = state as LoadSceneState;
            loadingState.Enterdktlot<TNextState>(sceneName, onLoad);
        }
    }
}
