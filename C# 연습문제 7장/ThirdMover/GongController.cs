using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GongController : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRd.AddForce(-speed, 0f, 0f);  //AddFore(x√‡,y√‡,z√‡)
        }

        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRd.AddForce(speed, 0f, 0f);
        }

        else if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRd.AddForce(0f, 0f, speed);
        }

        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRd.AddForce(0f, 0f, -speed);
        }
    }
}

