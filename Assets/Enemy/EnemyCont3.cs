using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont3 : MonoBehaviour
{
    [SerializeField] GameObject itemObj;          // �A�C�e���I�u�W�F�N�g

    public GameObject ExploPre; // �����̃v���n�u��ۑ�
    float speed;                // �ړ����x��ۑ�
    Vector3 dir;                // �ړ�������ۑ�
    GameDirector gd;            // GameDirector�R���|�[�l���g��ۑ�

    void Start()
    {
        dir = Vector3.left;             // �ړ�����
        speed = 10;                      // �ړ����x
        Destroy(gameObject, 6);		    // ����
        // GameDirector�R���|�[�l���g��ۑ�
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();

    }

    void Update()
    {
        // �ړ�����
        transform.position += dir.normalized * speed * Time.deltaTime;

    }

    // �d�Ȃ蔻�菈��
    void OnTriggerEnter2D(Collider2D other)
    {
        // �d�Ȃ�������̃^�O���yPlayer�z��������
        if (other.tag == "Player")
        {
            // ���������炷
            gd.Kyori -= 1000;

            // �d�Ȃ������肪�Փ˔����𐶐�
            Instantiate(ExploPre, transform.position, transform.rotation);

            // �����i�G�j�폜
            Destroy(gameObject);
        }

        // �d�Ȃ�������̃^�O���yPlayerShot�z��������
        if (other.tag == "PlayerShot")
        {
            // �����𑝂₷
            gd.Kyori += 200;

            // �d�Ȃ������肪�Փ˔����𐶐�
            Instantiate(ExploPre, transform.position, transform.rotation);

            // �����i�G�j�폜
            Destroy(gameObject);
        }

        // ���������̂��v���C���[�̒e
        if (other.tag == "PlayerShot")
        {
            // �A�C�e�����Z�b�g����Ă���ΐ���
            if (itemObj)
            {
                Instantiate(itemObj, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }

    }

}
