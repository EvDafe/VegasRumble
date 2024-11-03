namespace Assets.Scripts.Infrastructure.States
{
    public interface IState : IExitableState
    {
        public void Enterkdaqew();
    }

    public interface IExitableState
    {
        public void Exitdaodao();
    }

    public interface IPayLoadedState<TPayLoad> : IExitableState
    {
        public void Entervmfkte(TPayLoad payLoad);
    }

    public interface IDoublePayLoadedState<PPayLoad, HPayLoad> : IExitableState
    {
        public void Enterakmgnt(PPayLoad payLoad, HPayLoad payload1);
    }

    public interface ITriplePayloadedState<HPayLoad, UPayLoad, IPayLoad> : IExitableState
    {
        public void Enterfkltep(HPayLoad payLoad, UPayLoad payLoad1, IPayLoad payLoad2);
    }

    public interface IPlayerState : IState { }
}