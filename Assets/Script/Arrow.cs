using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public float speed;

	void Start()
	{
		Destroy(gameObject, 3);
	}

	void Update()
	{
		transform.position += transform.right * speed * Time.deltaTime;
	}

}
