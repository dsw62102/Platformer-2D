using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Coin : MonoBehaviour
{
    public float coin = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Coin_Component>().AddCoins(coin);
        Destroy(this.gameObject);
    }
}
