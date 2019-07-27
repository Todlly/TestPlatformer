using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlash : MonoBehaviour
{
  Animator anim;
  public GameObject LootBullet;
  // Start is called before the first frame update
  void Start()
  {
    anim = GetComponent<Animator>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      anim.SetTrigger("Attack");
    }
  }

  void OnTriggerEnter(Collider collision)
  {
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
}
