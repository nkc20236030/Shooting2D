using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont2 : MonoBehaviour
{
    public GameObject ExploPre; // �����̃v���n�u��ۑ�
    float speed;                // �ړ����x��ۑ�
    Vector3 dir;                // �ړ�������ۑ�
    GameDirector gd;            // GameDirector�R���|�[�l���g��ۑ�

    Transform player;

    void Start()
    {
        speed = 7;                      // �ړ����x

        // GameDirector�R���|�[�l���g��ۑ�
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();

        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        dir = player.position - transform.position;

        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    // �d�Ȃ蔻�菈��
    void OnTriggerEnter2D(Collider2D other)
    {
        // �d�Ȃ�������̃^�O���yPlayer�z��������
        if (other.tag == "Player")
        {
            // ���������炷
            gd.Kyori -= 3000;

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
    }

}
