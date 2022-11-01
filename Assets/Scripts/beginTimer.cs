using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beginTimer : MonoBehaviour
{
    [SerializeField]
    private Text _timer;
    
    // Update is called once per frame
    void Update()
    {
        
        if (globalVariables.timeLeft > 0 && pauseScript.isPaused == false)
        {
            globalVariables.timeLeft -= Time.deltaTime;
            _timer.text = ((int)(globalVariables.timeLeft)).ToString();

        }
        else if (globalVariables.timeLeft < 0) // if timer hits 0, player loses
        {
            globalVariables.timeLeft = 0;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("LevelFailed");
        }
    }
}
