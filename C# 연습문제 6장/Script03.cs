using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script03 : MonoBehaviour
{
    public float inch = 0f;
    private float cm = 0f;
    void Start()
    {
        cm = inch * 2.54f;
        Debug.Log("inch : " + inch);
        Debug.Log("Cm : " + cm);  
    }
}
