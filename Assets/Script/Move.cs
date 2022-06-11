using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        transform.position += -1 * transform.up * speed * Time.deltaTime;
    }
}
