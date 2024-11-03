using Assets.Scripts.Infrastructure.States;
using System.Collections.Generic;
using System;

namespace Assets.Scripts.Infrastructure
{
    public abstract class StateMachine
    {
        protected Dictionary<Type, IExitableState> _statesqnrmyk;
        protected IExitableState _currentStateqitnem;

        public TState GetStateemtkui<TState>() where TState : class, IExitableState =>
            _statesqnrmyk[typeof(TState)] as TState;

        public void Enterekqltr<TState>() where TState : class, IState
        {
            TState state = ChangeStatefnemnt<TState>();
            state.Enterkdaqew();
        }

        public void Enteradentm<TState, TPayLoad>(TPayLoad payLoad) where TState : class, IPayLoadedState<TPayLoad>
        {
            IPayLoadedState<TPayLoad> state = ChangeStatefnemnt<TState>();
            state.Entervmfkte(payLoad);
        }

        protected TState ChangeStatefnemnt<TState>() where TState : class, IExitableState
        {
            _currentStateqitnem?.Exitdaodao();

            TState stateblemyn = GetStateemtkui<TState>();
            _currentStateqitnem = stateblemyn;

            return stateblemyn;
        }
    }
}
