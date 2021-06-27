using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] spawnee;
    public GameObject fuelCan;
    public bool stopSpawning = false;

    private GameObject fuelCanCounter;
    private FuelCanCounter fuelCanCounterScript;
    
    void Start()
    {
        fuelCanCounter = GameObject.Find("FuelCanCounter");
        fuelCanCounterScript = fuelCanCounter.GetComponent<FuelCanCounter>();

        Invoke("SpawnObject", 2);
    }

    public void SpawnObject()
    {
        if(fuelCanCounterScript.count >= Random.Range(4, 6))
        {
            Instantiate(fuelCan, new Vector3(Random.Range(-4.5f, 4.5f), 5f, transform.position.z), transform.rotation);
            fuelCanCounterScript.count = -1;
        }
        else
        {
            System.Random random = new System.Random();
            int num = random.Next(0, spawnee.Length);
            Instantiate(spawnee[num], transform.position, transform.rotation);
        }
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }

        fuelCanCounterScript.count++;
    }
}
