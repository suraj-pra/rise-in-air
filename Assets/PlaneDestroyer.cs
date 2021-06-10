using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDestroyer : MonoBehaviour
{

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.SpawnObstacles.tag.equals("PlaneDestroyer"))
        {
            Destroy(collision.SpawnObstacles);
        }
    }
}
