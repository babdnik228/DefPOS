using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    public static Timer sing_timer;
    private void Start()
    {
        sing_timer = this;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            LevelManager.sing_level_manager.isActivator = true;
            LevelManager.sing_level_manager.is_state_F_L = true;
        }
    }
}
