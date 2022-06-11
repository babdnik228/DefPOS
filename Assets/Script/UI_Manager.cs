using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text timer_text;
    private void Update()
    {
        timer_text.text = Timer.sing_timer.timer.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Continue()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
