 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static float verVelocity = 0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public static float HeartTotal = 3;
    public static float forward = 1;
    public static string lvlStatus = "";
    public float waitToload = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTotal += Time.deltaTime;

        if(lvlStatus == "f")
        {
            waitToload += Time.deltaTime;
        }
        if (waitToload > 3)
        {
            SceneManager.LoadScene("Level Complete");
        }
    }
}
