using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* Donovan and ben
 * 4/23/2025
 * handles the UI elements
 */

public class UI_Manager : MonoBehaviour
{
    //Donovan and ben
    //4/19/2025
    // handles player and game ui
    public FPSController playerCtrl;
    public Waves waves;
    public EnemySpawn enemySpawn;


    public TMP_Text HealthText;
    public TMP_Text waveText;
    public TMP_Text enemyText;
    

    // Update is called once per frame
    void Update()
    {
       
        //display current wave
        waveText.text = "Wave: " + waves.waveCount;
        //displays the amount of enemies
        enemyText.text = "Enemies remaining: " + enemySpawn.enemyCount;

        if (playerCtrl.health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void PlayPressed(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void QuitPressed()
    {
        Application.Quit();
    }
    public void ReplayPressed(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}