﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemy : Enemy
{
    public void Start()
    {
        hp = 10;
        damage = 5;
        lootChance = 0.5f;
    }
}
