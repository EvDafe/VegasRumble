using Assets.Scripts.ServicesScripts;
using Assets.Scripts.ServicesScripts.Progress;
using System;

namespace Assets.CodeBase.Money
{
    public class Wallet : IService
    {
        private readonly LoadProgressService _progresspdqlel;

        public event Action ValueChangedqueidm;
        public int Moneyfkdleo => _progresspdqlel.Progressgkfjtu.Moneydlfkkb;

        public Wallet(LoadProgressService progress)
        {
            _progresspdqlel = progress;
        }

        public bool SpendMoneyvnfjgk(int amount)
        {
            bool validate = amount <= _progresspdqlel.Progressgkfjtu.Moneydlfkkb;
            if (validate)
                _progresspdqlel.Progressgkfjtu.Moneydlfkkb -= amount;

            ValueChangedqueidm?.Invoke();
            _progresspdqlel.Saveadlert();
            return validate;
        }

        public void AddMoneyvmfjri(int amount)
        {
            bool validate = amount >= 0;
            if (validate)
                _progresspdqlel.Progressgkfjtu.Moneydlfkkb += amount;
            else 
                throw new ArgumentException("Ты долбаёб", nameof(amount));

            ValueChangedqueidm?.Invoke();
            _progresspdqlel.Progressgkfjtu.CollectedMoneybkfmk += amount;
            _progresspdqlel.Saveadlert();
        }
    }
}
