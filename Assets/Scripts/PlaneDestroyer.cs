using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDestroyer : MonoBehaviour
{

    void OnCollisionEnter(Collision collider)
        {
            Destroy(collider.gameObject);
        }
    
}