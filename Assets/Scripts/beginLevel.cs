using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beginLevel : MonoBehaviour
{

    public GameObject blackOutSquare;
    // Start is called before the first frame update
    void Start()
    {
        //when level starts, flash a "level #" screen before it fades to black, giving the player
        //control of their character
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(FadeBlackOutSquare());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(FadeBlackOutSquare(false));
        }
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
}
