using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    Variables variables;
    FuelCapacity fuelCapacity;
    void Start() {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        fuelCapacity = GetComponent<FuelCapacity>();
    }
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("Game Over");
            variables.EndScene();
        }
        else if(collisionInfo.collider.tag == "RainDrop"){
            Destroy(collisionInfo.collider.gameObject);
            fuelCapacity.ReductionDrop();
        }
    }

    // void OnTriggerEnter(Collider collider) {
    //     if(collider.gameObject.tag == "Obstacle") {
    //         Debug.Log("Game Over");
    //         Application.Quit();
    //     }
    // }
}
