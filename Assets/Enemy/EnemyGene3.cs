using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGene3 : MonoBehaviour
{
    public GameObject Enemy3Pre; // 敵のプレハブを保存する変数
    float span = 10;             // 敵を出す間隔（秒）
    float delta = 0;            // 時間計算用変数

    void Update()
    {
        delta += Time.deltaTime; // 経過時間を計算

        // span秒毎に処理を行う
        if (delta > span)
        {
            delta = 0;  // 時間計算用変数を０にする

            // 敵のプレハブをヒエラルキーに登場させる
            GameObject go = Instantiate(Enemy3Pre);
            int py = Random.Range(-5, 6);
            go.transform.position = new Vector3(10, py, 0);

        }
    }
}
