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
    public float WaveDuration = 1f;

    private void Start()
    {
        StartCoroutine(WaveCheck());
    }
    
    private void StartWave()
    {
        
        if (enemySpawn.enemiesClear == true)
        {
            waveCount++;
            
            enemySpawn.WaveSpawn();

        }

    }
    
    private IEnumerator WaveCheck()
    {
        StartWave();

        yield return new WaitForSeconds(WaveDuration);
        StartCoroutine(WaveCheck());
    }

}
