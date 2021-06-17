using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainEndMarkerDownward : MonoBehaviour
{
    float speed = 5f;
    // Transform location;
    Vector3 down = new Vector3(0,0,-1);
    // void Start(){
    //     location = GetComponent<Transform>();
    // }
    // // Start is called before the first frame update

    // // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * down);
    }
}
