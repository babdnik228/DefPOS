using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    public Spawner spawner;
    public static bool finish = false;
    public static int level;
    private void Start()
    {
        finish = false;
    }
    private void Update()
    {
        if(finish == false)
        {
            Check();
        }
    }
    void Check()
    {
        if(spawner.spawnCount <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            if(enemies.Length == 0)
            {
                Victory();
            }
        }
        if(Player.sing.helth <= 0)
        {
            Defeat();
        }
    }
    void Victory()
    {
        finish = true;
    }
    void Defeat()
    {
        finish = false;
    }
}
