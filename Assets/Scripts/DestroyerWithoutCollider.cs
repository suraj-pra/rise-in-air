using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerWithoutCollider : MonoBehaviour
{
    void Update() {
        if(transform.position.z <= -20){
            Destroy(this.gameObject);
        }
    }
}

