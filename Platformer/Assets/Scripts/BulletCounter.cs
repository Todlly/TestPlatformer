using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
  Text counter;
  private int bullets;
  // Start is called before the first frame update
  void Start()
  {
    bullets = 3;
    counter = GetComponent<Text>();
  }

  // Update is called once per frame
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

  public void CollectBullet()
  {
    bullets++;
  }
}
