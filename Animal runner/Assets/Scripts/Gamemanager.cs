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

    public Transform laneWithoutPit;
    public Transform laneWithPit;
    public Transform coins;
    public Transform Obj;
    public Transform grasses;

    public int zStart;
    public int zTarget;
    int z = 1;
    //zScene += 5

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(laneWithoutPit, new Vector3(0, 1.5f,66f), laneWithoutPit.rotation);
        //Instantiate(laneWithoutPit, new Vector3(0, 1.5f, 70f), laneWithoutPit.rotation);
        //Instantiate(laneWithPit, new Vector3(0, y, 66.2f ), laneWithPit.rotation);
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
        
        addMorelane();
    }
    void addMorelane()
    {
        if (zStart < zTarget)
        {
            
            int randomNum = Random.Range(0, 9);
            if (randomNum < 9)
            {
                int x = Random.Range(-1, 2);
                Instantiate(coins, new Vector3(x, 1, z), coins.rotation);
            }
            if (randomNum > 3)
            {
                int x = Random.Range(-1, 2);
                Instantiate(Obj, new Vector3(x, 0.5f, z), Obj.rotation);
            }
            if (randomNum < 3)
            {
                int x = Random.Range(-1, 2);
                Instantiate(grasses, new Vector3(x, 1f, z), grasses.rotation);
            }


            Instantiate(laneWithoutPit, new Vector3(0, 0, zStart), laneWithoutPit.rotation);
            zStart += 10;
            z += 5;
        }
    }

}
