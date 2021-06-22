using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    public float speed;
    Vector3 movement = new Vector3(1,0,0);
    float zCordinate;
    // Update is called once per frame
    void Start(){
        System.Random random = new System.Random();
        zCordinate = random.Next(0,5);
    }
    void Update()
    {
        if(transform.position.z < zCordinate) transform.Translate(speed*Time.deltaTime*movement);
    }
}
