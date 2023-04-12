using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script06 : MonoBehaviour
{
    public float inch;
    float Inchchange(float inch)
    {
        float result = inch * 2.54f;
        return result;
    }
    void Start()
    {
        float change = Inchchange(inch);
        Debug.Log(change + "cm");
    }
}