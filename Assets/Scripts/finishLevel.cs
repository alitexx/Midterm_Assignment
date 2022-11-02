using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider otherModel)
    {
        if (otherModel.tag == "Player")
        {
            globalVariables.playerLevel = 2; // CHANGE IF MORE LEVELS ARE ADDED!!!! works for now
            Cursor.lockState = CursorLockMode.None;
            globalVariables.timeLeft = 185 - (globalVariables.playerLevel * 5);
            globalVariables.itemsCollected = 0;
            if (globalVariables.timeLeft < 120)
            {
                globalVariables.timeLeft = 120;
            }
            SceneManager.LoadScene("LevelCleared");
            
        }
    }



}
