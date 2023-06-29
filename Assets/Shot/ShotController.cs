using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    float speed;

    void Start()
    {
        speed = 7f;             // 弾速度
        Destroy(gameObject, 1.5f); // 寿命1.5秒
    }

    void Update()
    {
        // 移動
        transform.position += transform.up * speed * Time.deltaTime;
    }

    // 重なり判定
    void OnTriggerEnter2D(Collider2D c)
    {
        // 重なった相手のタグが【Enemy】だったら
        if (c.tag == "Enemy")
        {
            // 自弾削除
            Destroy(gameObject);
        }
    }
}

