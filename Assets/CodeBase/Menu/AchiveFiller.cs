using Assets.Scripts.ServicesScripts.Progress;
using Assets.Scripts.ServicesScripts;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.CodeBase.Menu
{
    public class AchiveFiller : MonoBehaviour
    {
        [SerializeField] private List<AchivementItem> _itemskqlroe;

        private void OnEnable()
        {
            SetAchivementStatesqeptp();
        }

        private void SetAchivementStatesqeptp()
        {
            for (int i = 0; i < _itemskqlroe.Count; i++)
            {
                if (Services.Containervnfmtk.Geteorpto<LoadProgressService>().Progressgkfjtu.UnlockAchivementsqekoer[i])
                    _itemskqlroe[i].Reachdofpgp();
                else
                    _itemskqlroe[i].Unreachdkgkhl();
            }
        }
    }
}
