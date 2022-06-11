using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 25;
    public int health_max = 25;
    public void TakeDamagePlayer(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            LevelManager.sing_level_manager.isActivator = true;
            LevelManager.sing_level_manager.is_state_F_L = false;
        }
    }
}
