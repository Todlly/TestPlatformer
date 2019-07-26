using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemCounter : MonoBehaviour
{

    public int count;
    Text counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<Text>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //counter.text = "Enemies killed: " + count;
    }
}
