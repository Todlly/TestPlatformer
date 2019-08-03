using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
  Text counter;
  private int bullets;

  void Start()
  {
    bullets = 3;
    counter = GetComponent<Text>();
  }

  void Update()
  {
    counter.text = "Bullets: " + bullets;
  }

  public bool CanShoot()
  {
    return bullets > 0;
  }

  public void Shoot()
  {
    bullets--;
  }

  public void CollectBullet(int count)
  {
    bullets += count;
  }
}
