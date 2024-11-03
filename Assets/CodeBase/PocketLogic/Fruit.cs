using Assets.CodeBase.Scores;
using Assets.Scripts.ServicesScripts;
using Assets.Scripts.ServicesScripts.Progress;
using System;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.CodeBase.PocketLogic
{
    public class Fruit : MonoBehaviour
    {
        [SerializeField] private float _fadeOutDuration;
        [SerializeField] private int _givenScores;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private Collider2D _collider;

        private float _currentDuration = 0f;
        private LevelScores _levelScores;

        public event Action FadedOut;

        [Inject]
        private void Contsruct(LevelScores levelScores)
        {
            _levelScores = levelScores;
        }

        private void OnValidate()
        {
            _spriteRenderer ??= GetComponent<SpriteRenderer>();
            _rigidbody ??= GetComponent<Rigidbody2D>();
            _collider ??= GetComponent<Collider2D>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.TryGetComponent(out Pocket pocket))
            {
                StartFadeOut();
            }
        }

        private IEnumerator FadeOut()
        {
            _currentDuration = 0f;
            _collider.isTrigger = true;
            _rigidbody.velocity = Vector2.zero;
            while (_currentDuration < _fadeOutDuration)
            {
                _currentDuration += 0.03f;
                _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, _currentDuration);
                yield return new WaitForSeconds(0.03f);
            }
            _levelScores.AddScores(_givenScores);
            FadedOut?.Invoke();
            Services.Containervnfmtk.Geteorpto<LoadProgressService>().Progressgkfjtu.PottedBallsCount++;
            Services.Containervnfmtk.Geteorpto<LoadProgressService>().Saveadlert();
            gameObject.SetActive(false);
        }

        public void StartFadeOut()
        {
            StartCoroutine(nameof(FadeOut));
        }

        public void Upgrade()
        {
            _givenScores *= 2;
            transform.localScale = transform.localScale * 1.1f;
        }
    }

}
