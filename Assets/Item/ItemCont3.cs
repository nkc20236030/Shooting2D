using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCont3 : MonoBehaviour
{
    SpriteRenderer spRender;    // レンダラーコンポーネント取得
    Vector3 pos;                // 出現位置

    void Start()
    {
        spRender = GetComponent<SpriteRenderer>();


        transform.position = pos;

        Destroy(gameObject, 3f);

    }

    void Update()
    {

    }
    // 重なり判定
    void OnTriggerEnter2D(Collider2D c)
    {
        // 重なった相手のタグが【Player】だったら
        if (c.gameObject.tag == "Player")
        {
            // PlayerControllerコンポーネントを保存
            PlayerController pCon = c.gameObject.GetComponent<PlayerController>();


            pCon.ShotLevel += 1;

            // 自分（アイテム）削除
            Destroy(gameObject);

        }
    }
}
