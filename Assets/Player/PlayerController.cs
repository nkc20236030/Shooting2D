using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject MyShotObj;        // �e�̃Q�[���I�u�W�F�N�g
    float speed;    // �ړ����x�ۑ�
    float timer;    // ���e�̔��ˊԊu�v�Z�p


    Vector3 dir; // �ړ�������ۑ�����ϐ�

    Animator animator;  // �A�j���[�^�[�R���|�[�l���g�̏���ۑ�

    void Start()
    {
        // �A�j���[�^�[�R���|�[�l���g�̏���ۑ�
        animator = GetComponent<Animator>();
        timer = 0;  // ���ԏ�����
        speed = 10; // �����X�s�[�h



    }

    void Update()
    {

        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;

        // ��ʓ��ړ�����
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        // �A�j���[�V�����ݒ�
        if(dir.y == 0)
        {
            // �A�j���[�V�����N���b�v
            animator.Play("Player");
        }
        else if(dir.y == 1)
        {
            animator.Play("PlayerL");
        }
        else if (dir.y == -1)
        {
            animator.Play("PlayerR");
        }

        // �{�^�����������Ƃ�
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // �e�̐����ʒu�̓v���[���[�Ɠ����ꏊ
            Vector3 p = transform.position;
            Quaternion rot = Quaternion.identity;
            rot.eulerAngles = transform.rotation.eulerAngles + new Vector3(0, 0, 0f);

            // �ʒu�Ɖ�]�����Z�b�g���Đ���
            Instantiate(MyShotObj, p, rot);
        }


    }
}
