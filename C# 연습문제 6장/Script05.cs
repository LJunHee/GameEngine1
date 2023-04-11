using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05 : MonoBehaviour
{
    private int start = 1;
    private int end = 10;
    void Start()
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        Debug.Log("Total : " + sum);
    }
}
