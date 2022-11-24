using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerUpPrefab,GenerateSpawnPosition(),powerUpPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
       
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerUpPrefab,GenerateSpawnPosition(),powerUpPrefab.transform.rotation);
        }
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
     for(int i = 0;i<enemiesToSpawn;i++)
     {
        Instantiate(enemyPrefab,GenerateSpawnPosition(),enemyPrefab.transform.rotation);
     }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPositionX = Random.Range(-spawnRange,spawnRange);
        float spawnPositionZ =Random.Range(-spawnRange,spawnRange);

        Vector3 randomPos = new Vector3(spawnPositionX,0,spawnPositionZ);
        return randomPos;
    }
}