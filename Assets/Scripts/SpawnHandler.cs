using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        

        Instantiate(enemyPrefab, GenerateSpawnPos(spawnRange), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GenerateSpawnPos(float var)
    {
        float spawnPositionX = Random.Range(-var, var);
        float spawnPositionZ = Random.Range(-var, var);

        Vector3 spawnPos = new Vector3(spawnPositionX, 0.125f, spawnPositionZ);

        return spawnPos;
    }
}
