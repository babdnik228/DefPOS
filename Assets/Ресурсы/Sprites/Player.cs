using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player sing;
    public int helth = 10;
    // Start is called before the first frame update
    void Start()
    {
        sing = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
