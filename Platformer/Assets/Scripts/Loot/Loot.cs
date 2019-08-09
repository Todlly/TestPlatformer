using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public int bullets;
    private BulletCounter bulletCounter = null;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (bulletCounter == null)
            {
                bulletCounter = GameObject.FindObjectOfType<BulletCounter>();
            }
            bulletCounter.CollectBullet(bullets);
            Destroy(gameObject, 0f);
        }
    }
}
