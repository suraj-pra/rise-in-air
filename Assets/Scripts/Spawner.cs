using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee1;
    public GameObject spawnee2;
    public GameObject spawnee3;
    public GameObject spawnee4;
    public GameObject spawnee5;
    public bool stopSpawning = false;
    public float startTime;
    public float spawnGap;

    void Start()
    {
        InvokeRepeating("SpawnObject", startTime, spawnGap);        
    }

    public void SpawnObject()
    {
        int num = Random.Range(1, 6);
        if (num == 1)
        {
            Instantiate(spawnee1, transform.position, transform.rotation);
        }
        else if(num == 2)
        {
            Instantiate(spawnee2, transform.position, transform.rotation);
        }
        else if (num == 3)
        {
            Instantiate(spawnee3, transform.position, transform.rotation);
        }
        else if (num == 4)
        {
            Instantiate(spawnee4, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(spawnee5, transform.position, transform.rotation);
        }
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
