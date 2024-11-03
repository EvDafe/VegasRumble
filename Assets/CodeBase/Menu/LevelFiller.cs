using Assets.Scripts.ServicesScripts.Progress;
using Assets.Scripts.ServicesScripts;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.CodeBase.Menu
{
    public class LevelFiller : MonoBehaviour
    {
        [SerializeField] private List<LevelItem> _itemvmfjgk;

        private PlayerProgress _progressekrtlto => Services.Containervnfmtk.Geteorpto<LoadProgressService>().Progressgkfjtu;

        private void Start()
        {
            InitializeItemdkwiri();
        }

        private void InitializeItemdkwiri()
        {
            _itemvmfjgk.ForEach(x => x.Lockvmgjek());
            for (int i = 1; i <= _itemvmfjgk.Count; i++)
            {
                _itemvmfjgk[i - 1].SetNumberajekrl(i);
            }
            for (int i = 10; i < _itemvmfjgk.Count; i++)
            {
                _itemvmfjgk[i].IDqotlrk = Random.Range(1,11);
            }
            for (int i = 0; i < _progressekrtlto.UnlockedLevelsCountdajijd; i++)
                _itemvmfjgk[i].Unlockfhdjsk();
        }
    }
}
