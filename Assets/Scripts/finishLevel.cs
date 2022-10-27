using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider otherModel)
    {
        Debug.Log(otherModel.tag);
        if (otherModel.tag == "Player")
        {
            globalVariables.playerLevel++;
            SceneManager.LoadScene("LevelCleared");
        }
    }



}
