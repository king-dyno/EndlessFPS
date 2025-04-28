using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* Donovan and Ben
 * 4/28/2025
 * handles the wave
 */

public class Waves : MonoBehaviour
{
    public EnemySpawn enemySpawn;

    //int for current wave
    public int waveCount = 0;

    private void Start()
    {

    }

    private void Update()
    {
        StartWave();
    }
    
    private void StartWave()
    {
        
        if (enemySpawn.enemiesClear == true)
        {
            waveCount++;
            
            enemySpawn.WaveSpawn();

        }

    }
    


}
