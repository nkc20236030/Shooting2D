using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    float speed;

    void Start()
    {
        speed = 10f;             // ’e‘¬“x
        Destroy(gameObject, 1.5f); // õ–½1.5•b
    }

    void Update()
    {
        // ˆÚ“®
        transform.position += transform.up * speed * Time.deltaTime;
    }

    // d‚È‚è”»’è
    void OnTriggerEnter2D(Collider2D c)
    {
        // d‚È‚Á‚½‘Šè‚Ìƒ^ƒO‚ªyEnemyz‚¾‚Á‚½‚ç
        if (c.tag == "Enemy")
        {
            // ©’eíœ
            Destroy(gameObject);
        }
    }
}

