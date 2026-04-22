using UnityEngine;

public class Coin_Component : MonoBehaviour
{
    public float coins;

    public delegate void CoinsEventHandler(float currentCoins, float amountChanged);
    public event CoinsEventHandler CoinAmountChanged;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        AddCoins(0);
    }

    public void AddCoins(float amount)
    {
        coins += amount;
        CoinAmountChanged?.Invoke(coins, amount);
    }
}
