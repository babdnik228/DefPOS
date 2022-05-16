using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstablishGun : MonoBehaviour
{
    public GameObject itemObjectPrefab;
    private void OnMouseDown()
    {
        if(ActivateGun.activateGun_singolton.is_activate_Gun == true)
        {
            GameObject itemObject = Instantiate(itemObjectPrefab, transform.position, Quaternion.identity);
        }
    }
}
