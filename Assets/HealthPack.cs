using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public float healing = 4;
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
        collision.GetComponent<healthComponent>().HealingValue(healing);
        Destroy(this.gameObject);
    }
}
