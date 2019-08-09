using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : Enemy
{
    public void Start()
    {
        hp = 15;
        damage = 8;
        lootChance = 1.0f;
    }
}
