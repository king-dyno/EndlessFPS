using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Donovan and Ben
 * 4/28/2025
 * handles the enemy spawning
 */

public class EnemySpawn : MonoBehaviour
{
    public Waves waves;
    public GameObject enemy;

    private float minSpawnRadius = 8f;
    private float maxSpawnRadius = 12f;
    //random distance from player to spawn enemy at
    public float spawnRadius;
    //angle from player that the enemy will spawn in
    private float spawnAngle;

    //bool for all enemies are dead
    public bool enemiesClear = true;
    //int to count the enemies
    public int enemyCount = 0;


    void Update()
    {
        if (enemyCount == 0)
        {
            enemiesClear = true;
        }
        else
        {
            enemiesClear = false;
        }
    }

    /// <summary>
    /// spawn a singular enemy
    /// </summary>
    public void SpawnEnemy()
    {
        spawnAngle = Random.Range(0f, 360f);
        spawnRadius = Random.Range(minSpawnRadius, maxSpawnRadius);

        Vector3 spawnDirection = new Vector3(Mathf.Cos(spawnAngle * Mathf.Deg2Rad), 0, Mathf.Sin(spawnAngle * Mathf.Deg2Rad));
        //position of the enemy spawn
        Vector3 spawnPosition = transform.position + spawnDirection * spawnRadius;

        Instantiate(enemy, spawnPosition,Quaternion.identity);
        enemyCount++;

    }

    /// <summary>
    /// Spawn enmies equal to the waves
    /// </summary>
    public void WaveSpawn()
    {
        for (int i = 0; i < waves.waveCount; i++)
        {
            SpawnEnemy();
        }
    }
}
