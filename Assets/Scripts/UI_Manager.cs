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
    public FPSController fpsCtrl;
    public Waves waves;
    public EnemySpawn enemySpawn;


  
    public TMP_Text waveText;
    public TMP_Text enemyText;
    public TMP_Text ammoText;
    

    // Update is called once per frame
    void Update()
    {

  

        //display current wave
        waveText.text = "Wave: " + waves.waveCount;
        //displays the amount of enemies
        enemyText.text = "Enemies remaining: " + enemySpawn.enemyCount;

        ammoText.text = "Bullets remaining: " + fpsCtrl.ammoCount;

        
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