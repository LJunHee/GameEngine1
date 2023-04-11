using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script02 : MonoBehaviour
{
    float inch = 4.8f;
    float cm = 0f;
    void Start()
    {
        Debug.Log("Inch: " + inch);
        cm = inch * 2.54f;
        Debug.Log("4.8inch -> " + cm + "cm");
    }
}
