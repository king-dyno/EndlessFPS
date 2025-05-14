using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{



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
