using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemCounter : MonoBehaviour
{

    public int count;
    Text counter;

    void Start()
    {
        counter = GetComponent<Text>();
        count = 0;
    }

    void Update()
    {
        counter.text = "Enemies killed: " + count;
    }

    public void AddKill()
    {
        count++;
    }
}
