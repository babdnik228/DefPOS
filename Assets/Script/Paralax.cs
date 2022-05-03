using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField]
    private float _speedParalax;
    [SerializeField]
    private float startX = 0;
    [SerializeField]
    private float endX;
    private void Update()
    {
        transform.Translate(Vector2.left * _speedParalax * Time.deltaTime);
        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, -1.910456f);
            transform.position = pos;
        }
    }
}
