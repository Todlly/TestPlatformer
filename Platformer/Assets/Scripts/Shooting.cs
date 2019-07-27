using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

  public GameObject BulletEmitter;
  public GameObject Bullet;
  public float force = 500f;

  private void Start()
  {

  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && GameObject.FindGameObjectWithTag("BulletCounter").GetComponent<BulletCounter>().Bullets > 0)
    {
      GameObject.FindGameObjectWithTag("BulletCounter").GetComponent<BulletCounter>().Bullets--;
      GameObject TempBullet;
      TempBullet = Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;
      Rigidbody TempGigidbody = TempBullet.GetComponent<Rigidbody>();
      TempGigidbody.AddForce(transform.forward * force);
      Destroy(TempBullet, 3f);
    }
  }



}
