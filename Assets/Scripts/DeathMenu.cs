using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public TMP_Text totalText;
    //total amount of enemies killed
    public int totalCount = 0;


    // Update is called once per frame
    void Update()
    {
        totalText.text = "Enemies Killed: " + totalCount;

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
