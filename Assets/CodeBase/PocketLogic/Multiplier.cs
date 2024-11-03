using UnityEngine;

namespace Assets.CodeBase.PocketLogic
{
    public class Multiplier : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.TryGetComponent(out Fruit fruit))
            {
                fruit.Upgrade();
            }
        }
    }
}
