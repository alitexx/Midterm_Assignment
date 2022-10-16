using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manageMainMenu : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode testingKey;
    private bool isPaused = false;

    private void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
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

    public void TogglePauseGame()
    {
        isPaused = !isPaused;
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
}