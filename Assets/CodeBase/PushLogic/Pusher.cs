using Assets.Scripts.ServicesScripts.Progress;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.CodeBase.PushLogic
{
    public class Pusher : MonoBehaviour
    {
        [SerializeField] float _pushPowerafwgeh;
        [SerializeField] float _pushResistanceafqgeh;
        [SerializeField] private Rigidbody2D _rigidbodyafwhej;

        public float PushPowerqesfdg => _pushPowerafwgeh;
        public float Magnitudeafsgdh => _rigidbodyafwhej.velocity.magnitude;
        public UnityEvent OnPush;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out Pusher pusher))
            {
                Pushafafaa(pusher);
            }
        }

        private void Pushafafaa(Pusher pusher)
        {
            var pusherPosition = pusher.transform.position;
            var direction = pusherPosition.FindReflectedVectorBetweenwesdcv(transform.position);
            direction = direction.normalized;
            Vector3 offset = direction * pusher.Magnitudeafsgdh * pusher.PushPowerqesfdg / _pushResistanceafqgeh;
            _rigidbodyafwhej.AddForce(offset, ForceMode2D.Impulse);
            OnPush?.Invoke();
        }
    }
}
