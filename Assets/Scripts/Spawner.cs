using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] spawnee;
    public bool stopSpawning = false;
    public float startTime = 10f;
    public float spawnGap = 10f;
    
    void Start()
    {
        InvokeRepeating("SpawnObject", startTime, spawnGap);        
    }

    public void SpawnObject()
    {
        System.Random random = new System.Random();
        int num = random.Next(0, spawnee.Length);
        Instantiate(spawnee[num], transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
