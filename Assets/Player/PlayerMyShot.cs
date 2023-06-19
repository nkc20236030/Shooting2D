using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMyShot : MonoBehaviour
{
    public float MoveSpeed;        // ˆÚ“®’l

    void Start()
    {
        MoveSpeed = 10f;             // ’e‘¬“x
        Destroy(gameObject, 2f); // Žõ–½‚Q•b
    }

    void Update()
    {
        // ˆÚ“®
        transform.position += transform.up * MoveSpeed * Time.deltaTime;

    }
}
