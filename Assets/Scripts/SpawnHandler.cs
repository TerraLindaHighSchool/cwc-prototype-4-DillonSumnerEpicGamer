using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;

    private float spawnRange = 9.0f;
    private int enemyCount;
    private int currentWave = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(currentWave);
        Instantiate(powerUpPrefab, GenerateSpawnPos(spawnRange), powerUpPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyHandler>().Length;
        if (enemyCount == 0)
        {
            currentWave++;
            SpawnEnemyWave(currentWave);
            Instantiate(powerUpPrefab, GenerateSpawnPos(spawnRange), powerUpPrefab.transform.rotation);
        }
    }

    void SpawnEnemyWave(int waveCount)
    {
        for (int i = 0; i < waveCount; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(spawnRange), enemyPrefab.transform.rotation);
        }
    }

    Vector3 GenerateSpawnPos(float var)
    {
        float spawnPositionX = Random.Range(-var, var);
        float spawnPositionZ = Random.Range(-var, var);

        Vector3 spawnPos = new Vector3(spawnPositionX, 0.125f, spawnPositionZ);

        return spawnPos;
    }
}
