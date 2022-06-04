using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float startX;
    [SerializeField] private float endX;
    private void Update()
    {
        transform.Translate(Vector2.left * speedX * Time.deltaTime);
        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, 0);
            transform.position = pos;
        }
    }
}
