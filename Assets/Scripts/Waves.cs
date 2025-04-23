using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* Donovan and ben
 * 4/23/2025
 * handles the wave and timer 
 */

public class Waves : MonoBehaviour
{
    //bool for all enemies are dead
    private bool enemiesClear;
    //int to count the enemies
    public int enemiesPresent = 0;
    //int for current wave
    public int waves = 0;
    //duration of each wave
    public float waveTimer = 30;
    //bool for the wave to be over in coroutine
    private bool waveOver;

    private void Start()
    {
        Wave();
    }

    private void Update()
    {
        if (enemiesPresent == 0)
        {
            enemiesClear = true;
            waveOver = true;
        }
    }
    
    private void Wave()
    {
        for (int i = 0; i < 100; i++)
        {
            if ((waveOver == true) && (enemiesClear == true))
            {
                waves++;
                StartCoroutine(WaveTimer());


            }




        }
    }
    
    private IEnumerator WaveTimer()
    {
        waveOver = false;
        yield return new WaitForSeconds(waveTimer);
        waveOver = true;

    }
    
    
}
