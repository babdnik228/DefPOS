using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform x;
    public Transform y;
    public float timer;
    public float spawnInervalMax = 3.5f;
    public float spawnInervalMin = 0.2f;
    public int spawnCount = 20;
    public int spawnLevel;

    // Start is called before the first frame update
    void Start()
    {
        spawnCount += spawnLevel * LevelControler.level;
    }

    // Update is called once per frame
    void Update()
    {
        if(LevelControler.finish == false)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else if (spawnCount > 0)
            {
                Spawn();
            }
        }
      
    }
    private void Spawn()
    {
        spawnCount--;
        timer = Random.Range(spawnInervalMin,spawnInervalMax);
        Vector3 position = transform.position;
        float randomY = Random.Range(x.position.y, y.position.y);
        position.y = randomY;
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
