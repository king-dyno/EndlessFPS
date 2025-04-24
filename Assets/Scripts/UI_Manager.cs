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
    
    public TMP_Text livesText;
    public TMP_Text waveText;


    // Update is called once per frame
    void Update()
    {
        //display lives
        livesText.text = "Lives: " + playerCtrl.lives; 
        //display current wave
        waveText.text = "Wave: " + waves.waves;

        if (playerCtrl.lives <= 0)
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