using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

  public GameObject BulletEmitter;
  public GameObject Bullet;
  public float force = 500f;

  private BulletCounter bulletCounter = null;

  void Update()
  {
    if (bulletCounter == null)
    {
      bulletCounter = GameObject.FindObjectOfType<BulletCounter>();
    }
    if (Input.GetMouseButtonDown(0) && bulletCounter.CanShoot())
    {
      bulletCounter.Shoot();
      GameObject TempBullet;
      TempBullet = Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;
      Rigidbody TempGigidbody = TempBullet.GetComponent<Rigidbody>();
      TempGigidbody.AddForce(transform.forward * force);
      Destroy(TempBullet, 3f);
    }
  }



}
