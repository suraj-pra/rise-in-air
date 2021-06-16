using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCollider : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag != "destroyer"){
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
