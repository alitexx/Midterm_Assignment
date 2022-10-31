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
        blackOutSquare.SetActive(true);
        startUI.SetActive(true);
        StartCoroutine(FadeBlackOutSquare(false)); // to fade out
        Debug.Log("Level " + globalVariables.playerLevel.ToString());
        _title.text = "Level " + globalVariables.playerLevel.ToString();


        Invoke("fadeOut", 2);
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
