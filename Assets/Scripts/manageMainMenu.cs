using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manageMainMenu : MonoBehaviour
{
    public GameObject blackOutSquare;
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
        StartCoroutine(FadeBlackOutSquare(sceneName)); // to fade in
        //StartCoroutine(FadeBlackOutSquare("", false)); // to fade out
    }

    public IEnumerator FadeBlackOutSquare(string beginLevel = "", bool fadeToBlack = true, int fadeSpeed = 5)
    {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        // an if statement in here that checks if the player is entering the game itself,
        // if so then change the level txt accordingly

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            while (blackOutSquare.GetComponent<Image>().color.a >= 1) {
                Debug.Log("I have loaded the level!");
                SceneManager.LoadScene(beginLevel);
                break;
            }
        }
        else
        {
            while (blackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
}