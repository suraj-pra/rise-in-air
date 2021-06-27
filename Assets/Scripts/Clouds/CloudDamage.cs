using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDamage : MonoBehaviour
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
            Debug.Log("Before Reduction:" + fuelCapacity.fuel.ToString());
            // fuelCapacity.ReductionCloud(20f);
            fuelCapacity.ReductionCloud(10f);
            Debug.Log("After Reduction:" + fuelCapacity.fuel.ToString());
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
