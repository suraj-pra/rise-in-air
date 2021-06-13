using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public GameObject[] spawnees;
    int randomInt;

    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0f, 0f, 0f);
        transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * speed);
        
        if(transform.position.z < -12.5f)
        {
            // randomInt = Random.Range(0, spawnees.Length);
            // Instantiate(spawnees[randomInt], new Vector3(Random.Range(-7.5f, 7.5f), 5f, 23.5f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            // Destroy(this.gameObject);

            transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 5f, 23.5f);
        }
    }
}
