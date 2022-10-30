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
            globalVariables.playerLevel++;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("LevelCleared");
        }
    }



}
