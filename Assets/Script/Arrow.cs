using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	private float speed;
	public int damage;

	void Start()
	{
		speed = Random.Range(2, 6);
		Destroy(gameObject, Random.Range(2,6));
	}

	void Update()
	{
		transform.position += transform.right * speed * Time.deltaTime;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		Enemy enemy = collision.GetComponent<Enemy>();
		if(enemy != null)
        {
			enemy.TakeDamage(damage);
        }
    }
}
