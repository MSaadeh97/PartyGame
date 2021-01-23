using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject bearPrefab;

    private float timeToSpawn = 2f;

    public float timeBetweenWaves = 1f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBears();
            timeToSpawn = Time.time + timeBetweenWaves;
        }





    }

    void SpawnBears()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(bearPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }


}
