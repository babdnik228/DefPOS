using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivate : MonoBehaviour
{
    public GameObject[] de_activate;
    private void Awake()
    {
        for (int i = 0; i < de_activate.Length; i++)
        {
            de_activate[i].SetActive(false);
        }
    }
   
}
