using UnityEngine;

namespace Assets.Scripts.ServicesScripts.Progress
{
    public class LoadProgressService : IService
    {
        private const string ProgressKeyekrkty = "Progress";
        
        public PlayerProgress Progressgkfjtu { get; private set; }

        public void Loadadoert()
        {
            Progressgkfjtu = PlayerPrefs.GetString(ProgressKeyekrkty) == null || PlayerPrefs.GetString(ProgressKeyekrkty).Length == 0 ? new() : PlayerPrefs.GetString(ProgressKeyekrkty).FromJsonsireot<PlayerProgress>();
            Debug.Log(Progressgkfjtu.ToJsonagtjyl());
        }

        public void Saveadlert()
        {
            PlayerPrefs.SetString(ProgressKeyekrkty, Progressgkfjtu.ToJsonagtjyl());
            //Debug.Log(Progress.ToJson());
        }

        public void Resetaotprl()
        {
            PlayerPrefs.DeleteAll();
            Loadadoert();
            Saveadlert();
        }
    }
}
