using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;    // �I�[�f�B�I�\�[�X�R���|�[�l���g�ۑ�
    AudioClip audioClip;        // �I�[�f�B�I�N���b�v�ۑ�
    AudioClip[] bgmClip = new AudioClip[3]; // �I�[�f�B�I�N���b�v�ۑ��i3�ȕ��j

    void Start()
    {
        string[] bgmName =
{
            "Audio/BGM/bgm_maoudamashii_8bit20",    // bgmName[0]
            "Audio/BGM/bgm_maoudamashii_8bit22",    // bgmName[1]
            "Audio/BGM/bgm_maoudamashii_8bit24"     // bgmName[2]
        };
        for (int i = 0; i < 3; i++)
        {
            bgmClip[i] = Resources.Load<AudioClip>(bgmName[i]);
        }

        // Resources�t�H���_���ɕۑ�����Ă���I�[�f�B�I�t�B������ǂݍ���
        audioClip = Resources.Load<AudioClip>("Audio/BGM/bgm_maoudamashii_8bit28");

        // �I�[�f�B�I�\�[�X�R���|�[�l���g�̏����擾
        audioSource = GetComponent<AudioSource>();

        // �I�[�f�B�I�\�[�X�ɃI�[�f�B�I�N���b�v���Z�b�g����
        audioSource.clip = audioClip;

        // �I�[�f�B�I�\�[�X�ɓo�^����Ă���I�[�f�B�I�N���b�v���Đ�����
        audioSource.Play();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �Đ�����I�[�f�B�I�N���b�v�����ւ���
            audioSource.clip = bgmClip[0];

            // �Z�b�g���ꂽ�I�[�f�B�I�N���b�v���Đ�����
            audioSource.Play();
        }


    }
}
