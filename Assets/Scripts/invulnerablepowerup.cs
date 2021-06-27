using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invulnerablepowerup : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Air_Balloon")
        {
           
            Destroy(this.gameObject);
        }
        
    }
}