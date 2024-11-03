using UnityEngine;
using UnityEngine.UI;

namespace Assets.CodeBase.Menu
{
    public class AchivementItem : MonoBehaviour
    {
        [SerializeField] private Image BGeotirk;
        [SerializeField] private Color _reachedColorakqmek;
        [SerializeField] private Color _unreachedColordhrjti;

        public void Reachdofpgp()
        {
            BGeotirk.color = _reachedColorakqmek;
        }

        public void Unreachdkgkhl()
        {
            BGeotirk.color = _unreachedColordhrjti;
        }
    }
}
