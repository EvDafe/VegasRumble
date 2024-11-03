using UnityEngine;

namespace Assets.CodeBase
{
    public class PortrainSellector : MonoBehaviour
    {
        private void Awake()
        {
            Screen.autorotateToPortrait = true;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
        }
    }
}
