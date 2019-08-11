using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 5f;
    Rigidbody ThePlayer;
    Animator animator;

    void Start()
    {
        ThePlayer = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
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

    public void Die()
    {
        animator.SetTrigger("IsDead");
    }
}
