using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timer = 3f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0f)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 3f;
        }
    }
}
