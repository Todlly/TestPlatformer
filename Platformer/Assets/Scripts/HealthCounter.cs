using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public float hp;
    public Text hpCounter;
    Rigidbody player;

    void Start()
    {
        hp = 15f;
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //hpCounter.text = "HP: " + hp;
        
    }


    void OnCollisionEnter(Collision enterer)
    {
        if(enterer.gameObject.tag == "Enemy")
        {
            hp--;
            player.AddForce(enterer.transform.forward * 500f);
        }
    }

}
