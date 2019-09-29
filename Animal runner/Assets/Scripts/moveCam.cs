using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, Gamemanager.verVelocity, speed * Gamemanager.forward);

    }
}
