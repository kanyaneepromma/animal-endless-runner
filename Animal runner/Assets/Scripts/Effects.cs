using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "coin")
        {
            transform.Rotate(0, 0, 6);
        }
        if (gameObject.tag == "grass")
        {
            transform.Rotate(0, 6, 0);
        }
    }
}
