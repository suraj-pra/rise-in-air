using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDamage : MonoBehaviour
{
    private FuelCapacity fuelCapacity;
    private bool hasEntered;

    void Start()
    {
        fuelCapacity = GameObject.Find("Air_Balloon").GetComponent<FuelCapacity>();

        hasEntered = false;
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(!hasEntered)
        {
            if (collider.gameObject.name == "Air_Balloon")
            {
                Debug.Log("Before Reduction: " + fuelCapacity.fuel.ToString());
                // fuelCapacity.ReductionCloud(20f);
                fuelCapacity.ReductionCloud(10f);
                Debug.Log("After Reduction: " + fuelCapacity.fuel.ToString());
            }
            
            hasEntered = true;
        }
    }
    // private void OnTriggerExit(Collider collider)
    // {
    //     if (collider.gameObject.name == "Air_Balloon")
    //     {
    //         fuelCapacity.reductionRatio = 2f;
    //     }
    // }
}