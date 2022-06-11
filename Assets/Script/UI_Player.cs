using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Player : MonoBehaviour
{
    public Slider scrollbar_health;
    public Health health_script;
    private void Update()
    {
        scrollbar_health.value = health_script.health;
        scrollbar_health.maxValue = health_script.health_max;
    }
}
