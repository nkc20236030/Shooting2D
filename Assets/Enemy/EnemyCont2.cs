using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont2 : MonoBehaviour
{
    public GameObject ExploPre; // 爆発のプレハブを保存
    float speed;                // 移動速度を保存
    Vector3 dir;                // 移動方向を保存
    GameDirector gd;            // GameDirectorコンポーネントを保存

    Transform player;

    void Start()
    {
        speed = 7;                      // 移動速度

        // GameDirectorコンポーネントを保存
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();

        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        dir = player.position - transform.position;

        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    // 重なり判定処理
    void OnTriggerEnter2D(Collider2D other)
    {
        // 重なった相手のタグが【Player】だったら
        if (other.tag == "Player")
        {
            // 距離を減らす
            gd.Kyori -= 3000;

            // 重なった相手が衝突爆発を生成
            Instantiate(ExploPre, transform.position, transform.rotation);

            // 自分（敵）削除
            Destroy(gameObject);
        }

        // 重なった相手のタグが【PlayerShot】だったら
        if (other.tag == "PlayerShot")
        {
            // 距離を増やす
            gd.Kyori += 200;

            // 重なった相手が衝突爆発を生成
            Instantiate(ExploPre, transform.position, transform.rotation);

            // 自分（敵）削除
            Destroy(gameObject);
        }
    }

}
