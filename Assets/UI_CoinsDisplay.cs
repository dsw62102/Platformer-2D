using TMPro;
using UnityEngine;

public class UI_CoinsDisplay : MonoBehaviour
{
    public Coin_Component coinComp;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        coinComp.CoinAmountChanged += CoinComp_CoinAmountChanged;
    }

    private void CoinComp_CoinAmountChanged(float currentCoins, float amountChanged)
    {
        coinText.text = currentCoins.ToString();
    }
}
