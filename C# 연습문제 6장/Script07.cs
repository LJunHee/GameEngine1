using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InchtoCm
{
    public float inch;  // ��� ���� , public�� �̿��� ����ڷ� ���� ���� �Է� ����.

    public InchtoCm(float inch) // ��� �޼���
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
        InchtoCm a = new InchtoCm(inch);   //InchtoCm Ŭ������ ����ϱ� ���� a�� ����
        float cm = a.ReturnCm();
        Debug.Log(inch + " inch = " + cm + " cm");
    }
}
