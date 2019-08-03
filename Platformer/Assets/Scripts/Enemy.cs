﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    public int damage;
    public float lootChance;
    public GameObject loot;

    public void Drop()
    {
        if (Random.value <= lootChance)
        {
            _ = Instantiate(loot, gameObject.transform.position - new Vector3(0f, 0.5f, 0f), gameObject.transform.rotation);
        }
    }
}