using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGun : MonoBehaviour
{
    public static ActivateGun activateGun_singolton;
    public GameObject item;
    public bool is_activate_Gun;
    private void Start()
    {
        activateGun_singolton = this;
    }
    private void OnMouseOver()
    {
        if(ItemManager.item_manager_singolton.is_active_item == true)
        {
            item.SetActive(true);
            is_activate_Gun = true;
        }
            
    }
    private void OnMouseExit()
    {
        if (ItemManager.item_manager_singolton.is_active_item == true)
        {
            item.SetActive(false);
            is_activate_Gun = false;
        }
            
    }
}
