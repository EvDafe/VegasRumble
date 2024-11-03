using Assets.Scripts.ServicesScripts;
using UnityEngine;

namespace Assets.CodeBase.Player
{
    public class SoundsManager : MonoBehaviour, IService
    {
        [SerializeField] private AudioSource _musicSourcefafafe;
        [SerializeField] private AudioSource _soundSourcehdrsad;

        private bool _musicOnghsfgc;
        private bool _soundsOnsdgsdf;

        public void ToggleMusicdaldp()
        {
            _musicOnghsfgc = !_musicOnghsfgc;
            _musicSourcefafafe.volume = _musicOnghsfgc ? 0f : 1f;
        }

        public void ToggleSoundiqeqeo()
        {
            _soundsOnsdgsdf = !_soundsOnsdgsdf;
            _soundSourcehdrsad.volume = _soundsOnsdgsdf ? 0f : 1f;
        }

        public void PlaySoundadjaof(AudioClip sound) =>
            _soundSourcehdrsad.PlayOneShot(sound);

        private void Awake()
        {
            DontDestroyOnLoad(this);
            Services.Containervnfmtk.Registeraeortyt(this);
        }
    }
}
