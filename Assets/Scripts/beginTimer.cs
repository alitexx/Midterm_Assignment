using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beginTimer : MonoBehaviour
{
    [SerializeField]
    private Text _timer;
    private float timeLeft = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            _timer.text = ((int)(timeLeft)).ToString();

        }
        else if (timeLeft < 0) // if timer hits 0, player loses
        {
            timeLeft = 0;
            SceneManager.LoadScene("LevelFailed");
        }
    }
}
