using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd; // Rigidbody ������Ʈ ����
    public float speed = 100.0f; // ���� �ӵ�
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>(); //Rigidbody ������Ʈ�� ã�Ƽ� ����
        // ������ �����ϸ� ���� ������ ��ġ���� ������ �������� ���
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

            Vector3 incomVec = currPos - startPos; // �Ի簢 ���
            Vector3 normalVec = collision.contacts[0].normal; // ���� ����
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢 ���
            reflectVec = reflectVec.normalized;

            // ballRd.AddForce(150.0f * dirx, 0f, 150.0f * dirz);
            ballRd.AddForce(reflectVec * speed);
        }
        startPos = transform.position; //���� ��ġ ���͸� �ٽ� ����
    }
}
