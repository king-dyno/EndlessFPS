using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Scene deathMenu;

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene == deathMenu)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        

    }
    void update()
    {
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
