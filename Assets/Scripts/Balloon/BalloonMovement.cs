using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{

    public Variables variables;
    public float movementRatio = 10f;
 
    void Start() {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape)){
            Debug.Log("Endscene Move");
            variables.EndScene();
        }

        if(transform.position.x < 6.4 && transform.position.x > -6.4){
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(movementRatio * Vector3.left * Time.deltaTime);
                Debug.Log("left");
            }
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(movementRatio * Vector3.right * Time.deltaTime);
                Debug.Log("right");
            }
        }
        else if(transform.position.x >= 6.4) {
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(movementRatio * Vector3.left * Time.deltaTime);
                Debug.Log("left");
            }
        }
        else {
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(movementRatio * Vector3.right * Time.deltaTime);
                Debug.Log("right");
            }
        }
    }
}
