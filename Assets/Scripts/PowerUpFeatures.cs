using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PowerUpFeatures : MonoBehaviour
{
    public float multiplier = 1.4f;
    public float bonusFuel = 10f;
    public float duration = 4f;
    private float speed;

    FuelCapacity fuelCapacity;
    Variables variables; 

    // Start is called before the first frame update
    void Start()
    {
        fuelCapacity = GameObject.Find("Air_Balloon").GetComponent<FuelCapacity>();
        variables = GameObject.Find("Variables").GetComponent<Variables>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine ( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player)
    {
        fuelCapacity.fuel = Math.Min(fuelCapacity.max_fuel, fuelCapacity.fuel + bonusFuel);
        speed = variables.getSpeed();
        speed *= multiplier;

        // GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        speed /= multiplier;

        Destroy(gameObject);
    }

}
