using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject ruler = Instantiate(prefab, transform.position, Quaternion.identity);
        ruler.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
//video de referencia: https://www.youtube.com/watch?v=AI8XNNRpTTw