using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMyShot : MonoBehaviour
{
    public float MoveSpeed;        // �ړ��l

    void Start()
    {
        MoveSpeed = 10f;             // �e���x
        Destroy(gameObject, 2f); // �����Q�b
    }

    void Update()
    {
        // �ړ�
        transform.position += transform.up * MoveSpeed * Time.deltaTime;

    }
}
