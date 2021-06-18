using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainBlockDestroyer : MonoBehaviour
{
    void Update()
    {
       if(transform.localPosition.z <= -23) {
           Destroy(this.transform.parent.gameObject);
       } 
    }
}
