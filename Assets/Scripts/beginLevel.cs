using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beginLevel : MonoBehaviour
{

    public GameObject blackOutSquare;
    public GameObject startUI;

    [SerializeField]
    private Text _title;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeBlackOutSquare(false)); // to fade out
        Debug.Log("Level " + globalVariables.playerLevel.ToString());
        _title.text = "Level " + globalVariables.playerLevel.ToString();


        Invoke("fadeOut", 3);
    }
    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, bool beginLevel = false, int fadeSpeed = 5)
    {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        } else
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

    public IEnumerator waitCommand(int waitTime)
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(waitTime);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    public void fadeOut()
    {
        StartCoroutine(FadeBlackOutSquare());
        Invoke("destroyUI", 1);
    }
    public void destroyUI()
    {
        startUI.SetActive(false);
        Invoke("fadeBack", 1);
    }
    public void fadeBack()
    {
        StartCoroutine(FadeBlackOutSquare(false));
    }

}
