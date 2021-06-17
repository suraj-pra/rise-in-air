using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDownward : MonoBehaviour
{
    float speed = 5f;
    public Rigidbody rb;
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        rb.AddForce(0,0, -speed, ForceMode.VelocityChange);
    }

    void Update(){
        // rb.AddForce(0,0, -speed, ForceMode.VelocityChange);
    }

}
