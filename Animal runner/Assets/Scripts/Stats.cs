using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Gamemanager.lvlStatus == "f")
        {
            if (gameObject.name == "Text")
            {
                GetComponent<Text>().text = "You died!";
            }
        }
       
        if (gameObject.name == "coinText")
        {
            GetComponent<Text>().text = "Coin: " + Gamemanager.coinTotal;
        }
        if (gameObject.name == "timeText")
        {
            GetComponent<Text>().text = "Time: " + Gamemanager.timeTotal;
        }
        if (gameObject.name == "heartText")
        {
            GetComponent<Text>().text = "Heart: " + Gamemanager.HeartTotal;
        }
        if (SwipeManager.IsSwipingUp())
        {
            //SceneManager.LoadScene("gameScene");
        }

    }
}
