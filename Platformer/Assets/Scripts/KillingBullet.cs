﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillingBullet : MonoBehaviour
{
  Rigidbody Bullet;
  public GameObject LootBullet;
  // Start is called before the first frame update
  void Start()
  {
    Bullet = GetComponent<Rigidbody>();
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Gun" && collision.gameObject.tag != "BulletLoot")
      Destroy(Bullet.gameObject, 0f);
    if (collision.gameObject.tag == "Enemy")
    {
      Destroy(collision.gameObject, 0f);
      GameObject.FindGameObjectWithTag("EnemyCounter").GetComponent<EnemCounter>().count += 1;
      if (Random.value < 0.4f)
      {
        GameObject TempLoot = Instantiate(LootBullet, collision.transform.position - new Vector3(0f, 0.5f, 0f), collision.transform.rotation);
      }
    }
  }

  void Update()
  {
    
  }

}
