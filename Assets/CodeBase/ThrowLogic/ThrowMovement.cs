using Assets.Scripts.ServicesScripts.Progress;
using System;
using UnityEngine;

namespace Assets.CodeBase.ThrowLogic
{
    public class ThrowMovement : MonoBehaviour
    {
        [SerializeField] protected float _throwPoweralfoie;
        [SerializeField] protected float _maxThrowDistancevmdkfl;
        [SerializeField] private Rigidbody2D _rigidbodyadelto;
        [SerializeField] private ThrowView _viewdkgkhk;
        [SerializeField] private float _minVelocity;

        private float _multiper = 1f;

        public event Action Throwed;
        public float MaxThrowDistancevfkeot => _maxThrowDistancevmdkfl;
        public bool CanThrow => _rigidbodyadelto.velocity.magnitude <= _minVelocity;

        private void OnValidate()
        {
            _rigidbodyadelto ??= GetComponent<Rigidbody2D>();
        }

        private void OnMouseDown()
        {
            if (CanThrow == false) return;
            _viewdkgkhk.ShowLine();
            _viewdkgkhk.ResetLine();
        }

        private void OnMouseUp()
        {
            if (CanThrow == false) return;
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Throwdkflto(mousePosition);
        }

        private void OnMouseDrag()
        {
            if (CanThrow == false) return;

            _viewdkgkhk.ShowLine();
            _viewdkgkhk.UpdateLine();
        }

        private void Update()
        {
            Debug.Log(CanThrow);
        }

        public virtual void Throwdkflto(Vector3 point)
        {
            if (point == null) throw new ArgumentException();

            Vector3 direction = point.FindReflectedVectorBetweenwesdcv(transform.position);
            direction.z = 0;
            point.z = 0;
            float distance = Vector3.Distance(point, transform.position);
            if (distance > _maxThrowDistancevmdkfl) distance = _maxThrowDistancevmdkfl;
            _rigidbodyadelto.AddForce(_throwPoweralfoie * distance * direction.normalized * _multiper, ForceMode2D.Impulse);
            Debug.Log(direction);
            _multiper = 1f;
            _viewdkgkhk.Hidefybkmf();
            Throwed?.Invoke();
        }

        public void Upgrade()
        {
            _multiper = 2f;
        }
    }
}
