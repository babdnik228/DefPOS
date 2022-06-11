using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public bool is_state_F_L;
    public bool isActivator;
    public static LevelManager sing_level_manager;
    //
    public GameObject panel_lose;
    public GameObject panel_finish;
    private void Start()
    {
        sing_level_manager = this;
    }
    private void Update()
    {
        Finish();
        Lose();
    }
    public void Finish()
    {
        if (is_state_F_L == true && isActivator == true)
        {
            panel_finish.SetActive(true);
        }
    }
    public void Lose()
    {
        if(is_state_F_L == false && isActivator == true)
        {
            panel_lose.SetActive(true);
        }
    }
}
