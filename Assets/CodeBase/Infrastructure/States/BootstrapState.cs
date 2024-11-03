using Assets.Scripts.ServicesScripts.Progress;
using Assets.Scripts.ServicesScripts;
using Assets.CodeBase.Money;

namespace Assets.Scripts.Infrastructure.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _gameStateMachineadodoo;
        private readonly ICoroutineRunner _coroutineRunnerdadkjk;

        public BootstrapState(GameStateMachine gameStateMachinedkakde, ICoroutineRunner coroutineRunnereqeqor)
        {
            _gameStateMachineadodoo = gameStateMachinedkakde;
            _coroutineRunnerdadkjk = coroutineRunnereqeqor;
        }

        public void Enterkdaqew()
        {
            RegisterServicesfhgrot();
            LoadNextSceneeqeofd();
        }

        private void LoadNextSceneeqeofd() => 
            Services.Containervnfmtk.Geteorpto<SceneLoadService>().LoadSceneejlsir<GameLoopState>("MenuScene");

        private void RegisterServicesfhgrot()
        {
            var loadingService = new LoadProgressService();
            Services.Containervnfmtk.Registeraeortyt(loadingService).Loadadoert();
            Services.Containervnfmtk.Registeraeortyt(new SceneLoadService(_gameStateMachineadodoo));
            Services.Containervnfmtk.Registeraeortyt(new Wallet(loadingService));
        }

        public void Exitdaodao()
        { }
    }
}
