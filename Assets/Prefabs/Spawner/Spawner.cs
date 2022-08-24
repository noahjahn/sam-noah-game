using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int chanceOfSpawning = 0;
    private int fixedUpdateCount = 0;

    void FixedUpdate()
    {
        fixedUpdateCount += 1;
        if (fixedUpdateCount % 50 == 0)
        {
            if (Random.Range(0, 100) < chanceOfSpawning)
            {
                SpawnEnemy();
                chanceOfSpawning = 0;
            } else
            {
                chanceOfSpawning += Random.Range(0, 20);
            }
            fixedUpdateCount = 0;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, new Vector2(Random.Range(0, 10), Random.Range(0, 10)), Quaternion.identity);
    }
}
