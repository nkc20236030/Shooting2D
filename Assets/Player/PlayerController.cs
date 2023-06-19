using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject MyShotObj;        // 弾のゲームオブジェクト
    float speed;    // 移動速度保存
    float timer;    // 自弾の発射間隔計算用


    Vector3 dir; // 移動方向を保存する変数

    Animator animator;  // アニメーターコンポーネントの情報を保存

    void Start()
    {
        // アニメーターコンポーネントの情報を保存
        animator = GetComponent<Animator>();
        timer = 0;  // 時間初期化
        speed = 10; // 初期スピード



    }

    void Update()
    {

        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;

        // 画面内移動制限
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        // アニメーション設定
        if(dir.y == 0)
        {
            // アニメーションクリップ
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

        // ボタンを押したとき
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // 弾の生成位置はプレーヤーと同じ場所
            Vector3 p = transform.position;
            Quaternion rot = Quaternion.identity;
            rot.eulerAngles = transform.rotation.eulerAngles + new Vector3(0, 0, 0f);

            // 位置と回転情報をセットして生成
            Instantiate(MyShotObj, p, rot);
        }


    }
}
