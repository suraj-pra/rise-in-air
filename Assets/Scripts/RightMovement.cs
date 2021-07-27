using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    public float speed;
    Vector3 movement = new Vector3(1,0,0);
    float zCordinate;
    public float xspeed;

    Variables variable;
    // Update is called once per frame
    void Start(){
        System.Random random = new System.Random();
        zCordinate = random.Next(0,5);
        variable = GameObject.Find("Variables").GetComponent<Variables>();
    }
    void Update()
    {
        xspeed = variable.getSpeed();
        if(transform.position.z < zCordinate) transform.Translate(speed * ( xspeed / 8f )*Time.deltaTime*movement);
    }
}
