using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Script04 : MonoBehaviour
{
    public int Score = 0;
    void Start()
    {
        if(Score >= 80)
        {
            Debug.Log("���");
        }
        else if(Score >= 60)
        {
            Debug.Log("����");
        }
        else
        {
            Debug.Log("����");
        }
    }
}
