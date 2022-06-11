using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMob : MonoBehaviour
{
    [SerializeField] private float Timer_interval;
    [SerializeField] private float Time_spawn;
    //
    [SerializeField] private GameObject mob;
    //
    [SerializeField] private Transform top_pos;
    [SerializeField] private Transform down_pos;
    

    private void Update()
    {
        Time_spawn -= Time.deltaTime;
        if(Time_spawn <= 0)
        {
            SpawnLogic();
        }
    }
    public void SpawnLogic()
    {
        float random_pos_y = Random.Range(top_pos.position.y, down_pos.position.y);
        Vector2 vector_pos = transform.position;
        vector_pos.y = random_pos_y;
        Instantiate(mob, vector_pos, Quaternion.identity);
        Time_spawn = Timer_interval;
    }
}
