using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd; // Rigidbody 컴포넌트 저장
    public float speed = 100.0f; // 공의 속도
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>(); //Rigidbody 컴포넌트를 찾아서 지정
        // 게임을 시작하면 공이 임의의 위치에서 임의의 방향으로 출발
        float X = Random.Range(-1f, 1f);
        float Z = Random.Range(-1f, 1f);
        Vector3 randomPos = new Vector3(X, 0f, Z).normalized;
        ballRd.AddForce(randomPos * speed);
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
        startPos = transform.position; //현재 위치 벡터를 다시 저장
    }
}
