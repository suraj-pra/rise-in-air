using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCanIncrementor : MonoBehaviour
{
    private FuelCapacity fuelCapacity;

    void Start()
    {
        fuelCapacity = GameObject.Find("Air_Balloon").GetComponent<FuelCapacity>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Air_Balloon")
        {
            Debug.Log("Before Increment: " + fuelCapacity.GetFuel().ToString());
            fuelCapacity.FuelCollection(30f);
            // fuelCapacity.FuelCollection(20f);
            Debug.Log("After Increment: " + fuelCapacity.GetFuel().ToString());
            Destroy(this.gameObject);
        }
    }
}
