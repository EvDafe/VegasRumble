using Assets.CodeBase.Money;
using Assets.Scripts.ServicesScripts.Progress;
using Assets.Scripts.ServicesScripts;
using UnityEngine;

namespace Assets.CodeBase.Menu
{
    public class AchivementsManager : MonoBehaviour
    {
        private PlayerProgress _progressfjtiyo => Services.Containervnfmtk.Geteorpto<LoadProgressService>().Progressgkfjtu;
        private LoadProgressService _progressServiceqkeoro => Services.Containervnfmtk.Geteorpto<LoadProgressService>();
        private Wallet _walletvjfmdk => Services.Containervnfmtk.Geteorpto<Wallet>();

        private void Awake()
        {
            DontDestroyOnLoad(this);
            if (_progressfjtiyo.UnlockAchivementsqekoer == null || _progressfjtiyo.UnlockAchivementsqekoer.Length == 0)
            {
                InitializeAchivementsqeqeqr();
            }
        }

        private void InitializeAchivementsqeqeqr()
        {
            _progressfjtiyo.UnlockAchivementsqekoer = new bool[] { false, false, false, false, false };
            _progressServiceqkeoro.Saveadlert();
        }

        private void Update()
        {
            if (_progressfjtiyo.UnlockedLevelsCountdajijd >= 2 && _progressfjtiyo.UnlockAchivementsqekoer[0] == false)
            {
                _progressfjtiyo.UnlockAchivementsqekoer[0] = true;
                _walletvjfmdk.AddMoneyvmfjri(100);
            }
            if (_progressfjtiyo.UnlockedLevelsCountdajijd >= 6 && _progressfjtiyo.UnlockAchivementsqekoer[1] == false)
            {
                _progressfjtiyo.UnlockAchivementsqekoer[1] = true;
                _walletvjfmdk.AddMoneyvmfjri(100);
            }
            if (_progressfjtiyo.UnlockedLevelsCountdajijd >= 10 && _progressfjtiyo.UnlockAchivementsqekoer[2] == false)
            {
                _progressfjtiyo.UnlockAchivementsqekoer[2] = true;
                _walletvjfmdk.AddMoneyvmfjri(100);
            }
            if (_progressfjtiyo.PottedBallsCount >= 10 && _progressfjtiyo.UnlockAchivementsqekoer[3] == false)
            {
                _progressfjtiyo.UnlockAchivementsqekoer[3] = true;
                _walletvjfmdk.AddMoneyvmfjri(100);
            }
            if (_progressfjtiyo.CollectedMoneybkfmk >= 3000 && _progressfjtiyo.UnlockAchivementsqekoer[4] == false)
            {
                _progressfjtiyo.UnlockAchivementsqekoer[4] = true;
                _walletvjfmdk.AddMoneyvmfjri(100);
            }
            _progressServiceqkeoro.Saveadlert();
        }
    }
}
