using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class healthComponent : MonoBehaviour
{
    private float health = 10;

    public float maxHealth = 10;

    public bool invincibility;

    public delegate void OnHealthChangedHandler(float newHealth, float amountChanged);
    public event OnHealthChangedHandler OnHealthChanged;

    public delegate void OnHealthInitializedHandler(float newHealth);
    public event OnHealthInitializedHandler OnHealthInitialized;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        OnHealthInitialized?.Invoke(health);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddDamage(float damage)
    {
        if (!invincibility)
        {
            health -= damage;
            OnHealthChanged?.Invoke(health, damage);
            invincibility = true;
            StartCoroutine(ResetInvincibility(3));
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator ResetInvincibility(float resetTime)
    {
        yield return new WaitForSeconds(resetTime);
        invincibility = false;
    }
    public void HealingValue(float healing)
    {
        health += healing;

        if (health >= maxHealth)
        {
            health = maxHealth;
        }
        Debug.Log(health);
        
        OnHealthChanged?.Invoke(health, healing);
        //Debug.Log(health);
    }

}
//currentHealth+= amount;
//OnHealthChanged?.Invoke(currentHealth, amount);
//Debug.Log(currentHealth);