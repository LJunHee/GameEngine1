using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script06 : MonoBehaviour
{
    public int inch = 0;
    private float cm = 0f;
    void Start()
    {
        cm = inch * 2.54f;
        Debug.Log(cm + "cm");
    }
}
