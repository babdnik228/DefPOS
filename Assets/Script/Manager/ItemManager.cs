using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager item_manager_singolton;
    public bool is_active_item;
    private void Start()
    {
        item_manager_singolton = this;
    }
    public void ClickItem()
    {
        is_active_item = true;
    }
}
