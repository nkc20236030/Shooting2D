using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;    // オーディオソースコンポーネント保存
    AudioClip audioClip;        // オーディオクリップ保存
    AudioClip[] bgmClip = new AudioClip[3]; // オーディオクリップ保存（3曲分）

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

        // Resourcesフォルダ内に保存されているオーディオフィルムを読み込む
        audioClip = Resources.Load<AudioClip>("Audio/BGM/bgm_maoudamashii_8bit28");

        // オーディオソースコンポーネントの情報を取得
        audioSource = GetComponent<AudioSource>();

        // オーディオソースにオーディオクリップをセットする
        audioSource.clip = audioClip;

        // オーディオソースに登録されているオーディオクリップを再生する
        audioSource.Play();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 再生するオーディオクリップを入れ替える
            audioSource.clip = bgmClip[0];

            // セットされたオーディオクリップを再生する
            audioSource.Play();
        }


    }
}
