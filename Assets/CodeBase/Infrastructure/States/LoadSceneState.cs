using System;

namespace Assets.Scripts.Infrastructure.States
{
    public class LoadSceneState : IDoublePayLoadedState<string, Action>
    {
        private SceneLoader _sceneLoaderkdfkti;
        private GameStateMachine _gameStateMachineejjrkt;
        private readonly LoadingCurtain _loadingCurtainaleorp;

        public LoadSceneState(GameStateMachine gameStateMachine, ICoroutineRunner coroutineRunner, LoadingCurtain loadingCurtain)
        {
            _gameStateMachineejjrkt = gameStateMachine;
            _loadingCurtainaleorp = loadingCurtain;
            _sceneLoaderkdfkti = new(coroutineRunner);
        }

        public void Enterakmgnt(string sceneNameaktiro, Action onLoadvmektl = null)
        {
            _loadingCurtainaleorp.Showfnjtky();
            _sceneLoaderkdfkti.LoadScenefkltro(sceneNameaktiro, onLoadvmektl);
        }

        public void Enterdktlot<TNextState>(string sceneNamefltoyp, Action onLoaddjltke = null) where TNextState : class, IState
        {
            onLoaddjltke += GoToNextStatevmgjkt<TNextState>;
            _gameStateMachineejjrkt.Enterdakodk<LoadSceneState, string, Action>(sceneNamefltoyp, onLoaddjltke);
        }

        private void GoToNextStatevmgjkt<TState>() where TState : class, IState => 
            _gameStateMachineejjrkt.Enterekqltr<TState>();

        public void Exitdaodao() => 
            _loadingCurtainaleorp.Hidedajerk();
    }
}
