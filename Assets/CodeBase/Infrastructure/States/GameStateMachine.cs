using System;
using System.Collections.Generic;

namespace Assets.Scripts.Infrastructure.States
{
    public class GameStateMachine : StateMachine
    {
        public GameStateMachine(ICoroutineRunner coroutineRunner, LoadingCurtain loadingCurtain)
        {
            _statesqnrmyk = new Dictionary<Type, IExitableState>()
            {
                [typeof(BootstrapState)] = new BootstrapState(this, coroutineRunner),
                [typeof(LoadSceneState)] = new LoadSceneState(this, coroutineRunner, loadingCurtain),
                [typeof(GameLoopState)] = new GameLoopState()
            };
        }

        public void Enterdakodk<TState, PPayLoad, HPayLoad>(PPayLoad payLoad, HPayLoad payLoad1) where TState : class, IDoublePayLoadedState<PPayLoad, HPayLoad>
        {
            IDoublePayLoadedState<PPayLoad, HPayLoad> state = ChangeStatefnemnt<TState>();
            state.Enterakmgnt(payLoad, payLoad1);
        }

        public void Entereoprpty<TState, HPayLoad, UPayLoad, IPayLoad>(HPayLoad payLoad, UPayLoad payLoad1, IPayLoad payLoad2) where TState : class, ITriplePayloadedState<HPayLoad, UPayLoad, IPayLoad>
        {
            ITriplePayloadedState<HPayLoad, UPayLoad, IPayLoad> state = ChangeStatefnemnt<TState>();
            state.Enterfkltep(payLoad, payLoad1, payLoad2);
        }
    }
}