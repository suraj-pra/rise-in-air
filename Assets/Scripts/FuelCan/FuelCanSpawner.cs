using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCanSpawner : MonoBehaviour
{
    public GameObject fuelCan;
    public bool stopSpawning = false;
    public float minTime;
    public float maxTime;

    void Start()
    {
        InvokeRepeating("SpawnFuelCan", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));
    }

    void SpawnFuelCan()
    {
        Instantiate(fuelCan, new Vector3(Random.Range(-4.5f, 4.5f), 5f, transform.position.z), transform.rotation);
    }
}
