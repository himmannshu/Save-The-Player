using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnner : MonoBehaviour
{

    public GameObject cubePrefab;
    float lastSpawned = 0;
    void Start()
    {
        spawnCubes();
    }

    void Update()
    {
        if (Time.time - lastSpawned > 0.6)
            spawnCubes();
    }


    void spawnCubes()
    {
        //gameObject.transform.
        lastSpawned = Time.time;
        float screenWidth = Camera.main.aspect * Camera.main.orthographicSize;
        Instantiate(cubePrefab, new Vector2(Random.Range(-screenWidth, screenWidth), Camera.main.orthographicSize + 3), Quaternion.identity);

    }
}
