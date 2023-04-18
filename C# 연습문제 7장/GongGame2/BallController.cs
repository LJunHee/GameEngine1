using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd; // Rigidbody 컴포넌트 저장
    public float speed = 100.0f; // 공의 속도
    Vector3 startPos;
    private int blockCount = 0; // 남아있는 블록 수

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>(); //Rigidbody 컴포넌트를 찾아서 지정
        
        startPos = new Vector3 (0,0,0);
        ballRd.AddForce(-speed, 0f, speed * 0.7f);

        // 시작 시 블록의 수를 계산하여 blockCount 변수에 저장
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("BLOCK");
        blockCount = blocks.Length;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // 입사각 계산
            Vector3 normalVec = collision.contacts[0].normal; // 법선 벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // 반사각 계산
            reflectVec = reflectVec.normalized;

            // ballRd.AddForce(150.0f * dirx, 0f, 150.0f * dirz);
            ballRd.AddForce(reflectVec * speed);
        }
        else if (collision.gameObject.CompareTag("PLAYER"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // 입사각 계산
            Vector3 normalVec = collision.contacts[0].normal; // 법선 벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // 반사각 계산
            reflectVec = reflectVec.normalized;

            // ballRd.AddForce(150.0f * dirx, 0f, 150.0f * dirz);
            ballRd.AddForce(reflectVec * speed);
        }
        else if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // 입사각 계산
            Vector3 normalVec = collision.contacts[0].normal; // 법선 벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // 반사각 계산
            reflectVec = reflectVec.normalized;

            // ballRd.AddForce(150.0f * dirx, 0f, 150.0f * dirz);
            ballRd.AddForce(reflectVec * speed);
            Destroy(collision.gameObject);
            blockCount--;
            if (blockCount == 0)
            {
                Destroy(gameObject);
            }
        }
        startPos = transform.position; //현재 위치 벡터를 다시 저장
    }
}
