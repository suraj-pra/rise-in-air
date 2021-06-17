using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainEnding : MonoBehaviour
{
    public float rainTime = 10f;
    public GameObject endMarker;
    bool endingDone = false;

    void Update()
    {
        if(rainTime <= 0 && !endingDone){
            GameObject spawner = this.transform.GetChild(0).gameObject;
            Destroy(spawner);
            Instantiate(endMarker, this.transform, false);
            endingDone = true;
        }
        else{
            rainTime -= Time.deltaTime;
        }
    }
}
