using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2f;
    float nextSpawn;

    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-2.5f, 2.8f),7);
            Instantiate(enemy, randomSpawnPosition, Quaternion.identity);
        }
    }
}
//video de referencia: https://www.youtube.com/watch?v=AI8XNNRpTTw
//video de referencia: https://www.youtube.com/watch?v=IbiwNnOv5So