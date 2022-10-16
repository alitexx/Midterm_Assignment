using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manageMainMenu : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void endGame()
    {
        // close game
        Application.Quit();
    }
    public void loadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}