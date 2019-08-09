﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public float hp;
    public Text hpCounter;
    Rigidbody player;


    void Start()
    {
        hp = 15f;
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hpCounter.text = "HP: " + hp;
    }


    void OnCollisionEnter(Collision enterer)
    {
        if (enterer.gameObject.tag == "Enemy")
        {
            GainDamage(enterer.gameObject.GetComponent<Enemy>());
        }
    }

    public void GainDamage(Enemy enemy)
    {
        hp -= enemy.damage;
        player.AddForce(enemy.transform.forward * 500f);
    }
}
