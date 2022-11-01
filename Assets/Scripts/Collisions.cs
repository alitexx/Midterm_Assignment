using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject door1;
    public GameObject gameCompletedDoor1;
    public GameObject door2;
    public GameObject gameCompletedDoor2;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            globalVariables.itemsCollected++;
            // checks if the player has unlocked the ending yet
            if (globalVariables.itemsCollected >= 3)
            {
                //hide current door, reveal ending door
                if (globalVariables.playerLevel == 1) {
                    door1.SetActive(false);
                    gameCompletedDoor1.SetActive(true);
                }
                if (globalVariables.playerLevel == 2)
                {
                    door2.SetActive(false);
                    gameCompletedDoor2.SetActive(true);
                }

            }
        }

    }
}
