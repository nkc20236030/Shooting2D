using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; // �ړ�����
    float speed = 5;

    void Start()
    {
        // ����4�b
        // Destroy(gameObject, 4f);
    }

    void Update()
    {
        // �ړ�����������
        dir = Vector3.left;

        // ���Ɍ��؂ꂽ��E����o��
        if (transform.position.x < -9f)
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }

        // Y�����̈ړ�
        // -1 <= Mathf.Sin(Time.time * 5f) <= 1
        // dir.x = 5f * Mathf.Cos(Time.time * 5f);
        dir.y = 5f * Mathf.Sin(Time.time * 5f);

        // ���ݒn�Ɉړ��ʂ����Z
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �������Ԃ�10�b���炷
        GameDirector.lastTime -= 10f;

        // �����̃I�u�W�F�N�g�ɏd�Ȃ��������
        Destroy(gameObject);

    }

}
