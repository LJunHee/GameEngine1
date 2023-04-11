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
            Debug.Log("우수");
        }
        else if(Score >= 60)
        {
            Debug.Log("보통");
        }
        else
        {
            Debug.Log("미흡");
        }
    }
}
