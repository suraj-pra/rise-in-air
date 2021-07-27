using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDownward : MonoBehaviour
{
    Variables variable;
    float speed;
    public Rigidbody rb;
    float xspeed;
    void Start()
    {
        variable = GameObject.Find("Variables").GetComponent<Variables>();
        speed = variable.getSpeed();
        // rb = GetComponent<Rigidbody>();
        rb.AddForce(0,0, -speed, ForceMode.VelocityChange);
    }

    void Update(){
        xspeed = variable.getSpeed();
        rb.AddForce(0,0, -(xspeed - speed), ForceMode.VelocityChange);

    }


}
