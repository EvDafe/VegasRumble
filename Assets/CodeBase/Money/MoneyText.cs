using Assets.Scripts.ServicesScripts;
using TMPro;
using UnityEngine;

namespace Assets.CodeBase.Money
{
    [RequireComponent(typeof(TMP_Text))]
    public class MoneyText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textlgptoy;

        private Wallet _walletdkltri;

        private void OnValidate() => 
            _textlgptoy ??= GetComponent<TMP_Text>();

        private void Awake() => 
            _walletdkltri = Services.Containervnfmtk.Geteorpto<Wallet>();

        private void OnEnable()
        {
            UpdateTextdaeryu();
            _walletdkltri.ValueChangedqueidm += UpdateTextdaeryu;
        }

        private void OnDisable() => 
            _walletdkltri.ValueChangedqueidm -= UpdateTextdaeryu;

        private void UpdateTextdaeryu() => 
            _textlgptoy.text = _walletdkltri.Moneyfkdleo.ToString();
    }
}
