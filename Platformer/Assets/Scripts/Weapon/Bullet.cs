using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Weapon
{

    private void Start()
    {
        damage = 10;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            DealDamage(enemy);
        }
        Destroy(gameObject, 0f);
    }
}
