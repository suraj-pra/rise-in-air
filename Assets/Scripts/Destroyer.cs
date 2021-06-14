using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float life = 50f;

    void Update()
    {
        if(this.transform.position.z <= -10)
        {
            Destruct();
        }

        void OnCollisionEnter(Collision boom)
        {
            if(boom.gameObject.name == "Air_Balloon")
            {
                Destruct();
            }
        }        
    }

    void Destruct()
    {
        Destroy(this.gameObject);
    }
}
