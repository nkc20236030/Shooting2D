using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGene2 : MonoBehaviour
{
    public GameObject Enemy2Pre; // �G�̃v���n�u��ۑ�����ϐ�
    float span = 5;             // �G���o���Ԋu�i�b�j
    float delta = 0;            // ���Ԍv�Z�p�ϐ�


    void Update()
    {
        delta += Time.deltaTime; // �o�ߎ��Ԃ��v�Z

        // span�b���ɏ������s��
        if (delta > span)
        {
            delta = 0;  // ���Ԍv�Z�p�ϐ����O�ɂ���

            // �G�̃v���n�u���q�G�����L�[�ɓo�ꂳ����
            GameObject go = Instantiate(Enemy2Pre);
            int py = Random.Range(-5, 6);
            go.transform.position = new Vector3(10, py, 0);
        }
    }
}
