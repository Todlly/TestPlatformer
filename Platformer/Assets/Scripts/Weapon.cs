using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;
    private EnemCounter enemCounter;

    private void Update()
    {
        if(enemCounter == null)
        {
            enemCounter = GameObject.FindObjectOfType<EnemCounter>();
        }
    }

    public void Kill(Enemy enemy)
    {
        enemy.Drop();
        Destroy(enemy.gameObject, 0f);
        enemCounter.AddKill();
    }

    public void DealDamage(Enemy enemy)
    {
        if (enemy.hp - damage > 0)
        {
            enemy.hp -= damage;
        }
        else
        {
            Kill(enemy);
        }
    }
}
