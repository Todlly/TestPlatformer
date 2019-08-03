using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timerDelay;
    public float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            _ = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = timerDelay;
        }
    }
}
