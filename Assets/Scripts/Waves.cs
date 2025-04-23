using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Waves : MonoBehaviour
{
    //bool for all enemies are dead
    public bool enemiesClear;
    //int to count the enemies
    private int enemiesPresent = 0;
    //int for current wave
    public int waves = 0;
    public float waveTimer = 30;
    //bool for the wave to be over in coroutine
    private bool waveOver;

    private void Start()
    {
        Wave();
        StartCoroutine(Test());
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
               // StartCoroutine(WaveTimer());


            }




        }
    }
    /*
    private IEnumerator WaveTimer()
    {
        waveOver = false;
        yield return new WaitForSeconds(waveTimer);
        waveOver = true;

    }
    */
    private IEnumerator Test()
    {
        print("Before");
        yield return new WaitForSeconds(3);
        print("after");
    }
    
}
