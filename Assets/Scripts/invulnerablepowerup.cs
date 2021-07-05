using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invulnerablepowerup : MonoBehaviour
{ var invulnerable : boolean = false;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Air_Balloon")
        {
           
            Destroy(this.gameObject);
        }
        
    }
    function onTriggerEnter(collider collider)
    {
        if (!invulnerable)
        {
            if (collider.gameObject.name == "SpawnObject")
            {
                invulnerable = true;
                yield waitforseconds(5);
                invulnerable = false;
            }
        }
    }
}