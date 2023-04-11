using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InchtoCm
{
    public float inch;  // 멤버 변수 , public을 이용해 사용자로 부터 값을 입력 받음.

    public InchtoCm(float inch) // 멤버 메서드
    {
        this.inch = inch;
    }
    public float ReturnCm()
    {
        return inch * 2.54f;
    }
}
public class Script07 : MonoBehaviour
{
    public float inch = 0.0f;
    void Start()
    {
        InchtoCm a = new InchtoCm(inch);   //InchtoCm 클래스를 사용하기 위해 a를 생성
        float cm = a.ReturnCm();
        Debug.Log(inch + " inch = " + cm + " cm");
    }
}
