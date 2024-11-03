using Assets.Scripts.ServicesScripts.Progress;
using System;
using UnityEngine;

namespace Assets.CodeBase.ThrowLogic
{
    public class ThrowView : MonoBehaviour
    {
        [SerializeField] protected float _maxThrowDistancedkelrl;
        [SerializeField] private LineRenderer _lineRendererdfidog;

        private float _multipier = 1f;

        public void UpdateLine()
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _lineRendererdfidog.SetPosition(1, Throwaflept(mousePosition) * _multipier);
        }

        public void ResetLine()
        {
            _lineRendererdfidog.SetPosition(1, transform.position);
        }

        public void Hidefybkmf()
        {
            _lineRendererdfidog.gameObject.SetActive(false);
            enabled = false;
        }

        public void ShowLine()
        {
            enabled = true;
            _lineRendererdfidog.gameObject.SetActive(true);
        }

        public virtual Vector3 Throwaflept(Vector3 pointvemtny)
        {
            if (pointvemtny == null) throw new ArgumentException();

            Vector3 directionslfiho = pointvemtny.FindReflectedVectorBetweenwesdcv(transform.position);
            pointvemtny.z = 0;
            directionslfiho.z = 0;
            float distancedflbot = Vector3.Distance(pointvemtny, transform.position);
            if (distancedflbot > _maxThrowDistancedkelrl) distancedflbot = _maxThrowDistancedkelrl;
            return distancedflbot * directionslfiho.normalized;
        }

        public void Upgrade()
        {
            _multipier = 2f;
        }
    }
}
