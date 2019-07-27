using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
  Text counter;
  public int Bullets;
    // Start is called before the first frame update
    void Start()
    {
    Bullets = 3;
    counter = GetComponent<Text>();
    }
  
    // Update is called once per frame
    void Update()
    {
    counter.text = "Bullets: " + Bullets;
    }
}
