using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    float score = 0f;
    int speedOfTravel = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += speedOfTravel * Time.deltaTime;
    }

    public int getScore() {
        return (int)score;
    }
}
