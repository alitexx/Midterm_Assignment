using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour
{
   
    public GameObject menu;
    public KeyCode testingKey;
    public static bool isPaused = false;

    private void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }
    public void endGame()
    {
        SceneManager.LoadScene("TitleScreen");
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
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }

    }

}
