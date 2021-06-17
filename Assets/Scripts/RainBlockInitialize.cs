using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainBlockInitialize : MonoBehaviour
{
    public GameObject [] umbrellaPaths;
    int umbrellaPath;
    bool umbrellaCreated = false;
    public GameObject start;
    GameObject startMarker;
    // Start is called before the first frame update
    void Start()
    {
        startMarker = Instantiate(start, this.transform, false);
    }

    void Update(){
        if(startMarker.transform.position.z <= -3 && !umbrellaCreated){
            UmbrellaInstantiate();
            umbrellaCreated = true;
        }
    }
    void UmbrellaInstantiate(){
        System.Random random = new System.Random();
        umbrellaPath = random.Next(0,umbrellaPaths.Length);
        Instantiate(umbrellaPaths[umbrellaPath], this.transform, true);
    }
}
