using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGene2 : MonoBehaviour
{
    public GameObject Enemy2Pre; // 敵のプレハブを保存する変数
    float span = 5;             // 敵を出す間隔（秒）
    float delta = 0;            // 時間計算用変数


    void Update()
    {
        delta += Time.deltaTime; // 経過時間を計算

        // span秒毎に処理を行う
        if (delta > span)
        {
            delta = 0;  // 時間計算用変数を０にする

            // 敵のプレハブをヒエラルキーに登場させる
            GameObject go = Instantiate(Enemy2Pre);
            int py = Random.Range(-5, 6);
            go.transform.position = new Vector3(10, py, 0);
        }
    }
}
