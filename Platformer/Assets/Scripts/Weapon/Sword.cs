using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    Animator anim;

    void Start()
    {
        damage = 10;
    }

    void FixedUpdate()
    {
        if (anim == null)
        {
            anim = GetComponent<Animator>();
        }
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetTrigger("Attack");
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            DealDamage(enemy);
        }
    }
}
