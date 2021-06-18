using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownwardMovement : MonoBehaviour
{
    float speed = 5f;
    Vector3 down = new Vector3(0,0,-1);
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * down);
    }
}
