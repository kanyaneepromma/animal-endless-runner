using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveOrb : MonoBehaviour
{
    public float speed;
    public float horiVelocity = 0;
    //เก็บไว้ในเลน
    public int laneNum = 2;

    //ล็อคการควบคุม
    public string controlLocked = "n";

    public Transform bombObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int y = 0;
        GetComponent<Rigidbody>().velocity = new Vector3(horiVelocity, y, speed);
        //GetComponent<Rigidbody>().velocity = new Vector3(horiVelocity, Gamemanager.verVelocity, speed);
        if (SwipeManager.IsSwipingLeft() && laneNum > 1 && controlLocked == "n")
        {
            horiVelocity = -2;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        if (SwipeManager.IsSwipingRight() && laneNum < 3 && controlLocked == "n")
        {
            horiVelocity = 2;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
        
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horiVelocity = 0;
        controlLocked = "n";
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "lethal")
        {
            Destroy(other.gameObject);
            Gamemanager.HeartTotal -= 1;
            Instantiate(bombObj, transform.position,bombObj.rotation);
            
            if(Gamemanager.HeartTotal < 1)
            {
                Destroy(gameObject);
                Gamemanager.forward = 0;
                Gamemanager.lvlStatus = "f";
            }
        }
        if(other.gameObject.tag == "coin")
        {
            //เพิ่มบางอย่างตรงนี้ก็ได้
           
            //if (Gamemanager.HeartTotal < 3) Gamemanager.HeartTotal += 1;
            Destroy(other.gameObject);
            Gamemanager.coinTotal += 1;
        }
        if (other.gameObject.tag == "grass")
        {
            Destroy(other.gameObject);
            if (Gamemanager.HeartTotal < 3)
                Gamemanager.HeartTotal += 1;
           
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "ramButtomTrigger")
        {
            Gamemanager.verVelocity = 2;
        }
        if (other.gameObject.name == "ramTopTrigger")
        {
            Gamemanager.verVelocity = 0;
        }
        if(other.gameObject.name == "exit")
        {
            SceneManager.LoadScene("Level Complete");
        }
        
    }
}
