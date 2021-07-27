using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    float score = 0f;
    Variables variable;
    int speedOfTravel;
    int prevRem;
    int rem;
    int x = 500;
    int remainderScore;
    bool secondTime = false;
    bool count = true;
    bool count2 =  false;

    Spawner spawnerScript;
    void Start()
    {
        variable = GameObject.Find("Variables").GetComponent<Variables>();
        spawnerScript = GameObject.Find("Spawner").GetComponent<Spawner>();
        prevRem = (int)score / x;
        rem = (int)score / x;
    }

    // Update is called once per frame
    void Update()
    {
        speedOfTravel = (int)variable.getSpeed();
        score += speedOfTravel * Time.deltaTime;
        rem = (int)score / x;
        // remainderScore = x - ((int)score % x);
        // Debug.Log("remainderScore: " + remainderScore);
        // Debug.Log("rem: " + rem + ", prevRem: " + prevRem);
        
        // if(remainderScore <= 33 && count) {
        //     spawnerScript.gameObject.SetActive(false);
        //     Destroy(GameObject.Find("RainObstacle").gameObject);
        //     count = false;
        //     secondTime = true;
        // }

        // if(remainderScore >= 473 && secondTime) {
        //     spawnerScript.gameObject.SetActive(true);
        //     spawnerScript.SpawnObject();
        //     secondTime = false;
        //     count = true;
        // }

        if(rem - prevRem == 1){
            variable.increaseSpeed();
            prevRem = rem;
        }
        // variable.increaseSpeed();
    }

    public int getScore() {
        return (int)score;
    }

    void OnDisable(){
        PlayerPrefs.SetInt("score", (int)score);
    }
}
