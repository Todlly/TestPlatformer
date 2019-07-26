using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 5f;
    Rigidbody ThePlayer;

    void Start()
    {
        ThePlayer = GetComponent<Rigidbody>();
    }
    Vector3 newPos;
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        newPos.Set(h, 0f, v);
        newPos = newPos.normalized * Speed * Time.deltaTime;
        ThePlayer.MovePosition(transform.position + newPos);
    }
}
