using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCont3 : MonoBehaviour
{
    SpriteRenderer spRender;    // �����_���[�R���|�[�l���g�擾
    Vector3 pos;                // �o���ʒu

    void Start()
    {
        spRender = GetComponent<SpriteRenderer>();


        transform.position = pos;

        Destroy(gameObject, 3f);

    }

    void Update()
    {

    }
    // �d�Ȃ蔻��
    void OnTriggerEnter2D(Collider2D c)
    {
        // �d�Ȃ�������̃^�O���yPlayer�z��������
        if (c.gameObject.tag == "Player")
        {
            // PlayerController�R���|�[�l���g��ۑ�
            PlayerController pCon = c.gameObject.GetComponent<PlayerController>();


            pCon.ShotLevel += 1;

            // �����i�A�C�e���j�폜
            Destroy(gameObject);

        }
    }
}
