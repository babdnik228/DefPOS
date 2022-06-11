using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public int damage;
    private void Start()
    {
        Destroy(gameObject, 12f);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0 )
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health_script = collision.GetComponent<Health>();
        if(health_script != null)
        {
            health_script.TakeDamagePlayer(damage);
            Destroy(gameObject);
        }
    }
}
