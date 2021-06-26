using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCapacity : MonoBehaviour
{
    public float fuel;
    public float max_fuel = 100f;
    public float reductionRatio;
    // Start is called before the first frame update
    void Start()
    {
        fuel = max_fuel;
        reductionRatio = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        fuel -= (Time.deltaTime * reductionRatio) % 100;
        if(fuel <= 0){
            terminate();
        }
    }

    void terminate(){
        //to traverse to next scene;
        Application.Quit();
    }

    public void ReductionCloud(float cloudReduction) {
        fuel = Mathf.Min(fuel - cloudReduction, 100);
    }

    public void FuelCollection(float increment) {
        fuel = Mathf.Min(fuel + increment, 100);
    }
}
