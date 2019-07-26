using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillingBullet : MonoBehaviour
{
    Rigidbody Bullet;
    // Start is called before the first frame update
    void Start()
    {
        Bullet = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "Gun")
            Destroy(Bullet.gameObject, 0f);
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject, 0f);
            GameObject.FindGameObjectWithTag("EnemyCounter").GetComponent<EnemCounter>().count += 1;
        }
    }

    void Update()
    {
        
    }
}
