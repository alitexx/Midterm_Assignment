using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject door;
    public GameObject gameCompletedDoor;
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
                door.SetActive(false);
                gameCompletedDoor.SetActive(true);
}
        }

    }
}
