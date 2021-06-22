using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    public float speed;
    Vector3 movement = new Vector3(1,0,0);

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime*movement);
    }
}
