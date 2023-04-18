using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd; // Rigidbody ������Ʈ ����
    public float speed = 100.0f; // ���� �ӵ�
    Vector3 startPos;
    private int blockCount = 0; // �����ִ� ��� ��

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>(); //Rigidbody ������Ʈ�� ã�Ƽ� ����
        
        startPos = new Vector3 (0,0,0);
        ballRd.AddForce(-speed, 0f, speed * 0.7f);

        // ���� �� ����� ���� ����Ͽ� blockCount ������ ����
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

            Vector3 incomVec = currPos - startPos; // �Ի簢 ���
            Vector3 normalVec = collision.contacts[0].normal; // ���� ����
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢 ���
            reflectVec = reflectVec.normalized;

            // ballRd.AddForce(150.0f * dirx, 0f, 150.0f * dirz);
            ballRd.AddForce(reflectVec * speed);
        }
        else if (collision.gameObject.CompareTag("PLAYER"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // �Ի簢 ���
            Vector3 normalVec = collision.contacts[0].normal; // ���� ����
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢 ���
            reflectVec = reflectVec.normalized;

            // ballRd.AddForce(150.0f * dirx, 0f, 150.0f * dirz);
            ballRd.AddForce(reflectVec * speed);
        }
        else if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos; // �Ի簢 ���
            Vector3 normalVec = collision.contacts[0].normal; // ���� ����
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢 ���
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
        startPos = transform.position; //���� ��ġ ���͸� �ٽ� ����
    }
}
