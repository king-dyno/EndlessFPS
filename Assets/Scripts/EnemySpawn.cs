using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Donovan and ben
 * 4/23/2025
 * handles the enemy spawning
 */

public class EnemySpawn : MonoBehaviour
{
    public Waves waves;

    public GameObject enemy;

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        Instantiate(enemy);
        waves.enemiesPresent++;

    }
}
