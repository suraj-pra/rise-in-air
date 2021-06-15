using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] spawnee = new GameObject[5];
    public bool stopSpawning = false;
    public float spawnTime = 10f;
    public float spawnDelay = 0.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnObject", startTime, spawnGap);        
    }

    public void SpawnObject()
    {
        System.Random random = new System.Random();
        int num = random.Next(1, 6);
        Instantiate(spawnee[num], transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
