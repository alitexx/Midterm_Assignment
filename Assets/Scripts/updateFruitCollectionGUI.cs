using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateFruitCollectionGUI : MonoBehaviour
{
    [SerializeField]
    private Text _overheadGUI;
    public static int maxNumberOfFruit = 2;
    private int lastKnownFruitVal = 0;
    private void Start()
    {
        maxNumberOfFruit = maxNumberOfFruit + globalVariables.playerLevel;
        _overheadGUI.text = ((maxNumberOfFruit).ToString() + " Fruit Left");

    }
    void Update()
    {
        if (lastKnownFruitVal < globalVariables.itemsCollected) {
            // if the player obtains an item, itemscollected goes up by 1.
            // meaning, this triggers when the player grabs an item
            lastKnownFruitVal = globalVariables.itemsCollected;
            maxNumberOfFruit--;
            _overheadGUI.text = ((maxNumberOfFruit).ToString() + " Fruit Left");
        }

    }
}
