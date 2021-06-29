using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUp;
    public bool stopSpawning = false;
    public float minTime;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));
        // Invoke("SpawnPowerUp", 2);
    }

    void SpawnPowerUp()
    {
        Instantiate(powerUp, new Vector3(Random.Range(-4.5f, 4.5f), 5f, transform.position.z), transform.rotation);
        if(stopSpawning)
        {
            CancelInvoke("SpawnPowerUp");
        }
    }

}
