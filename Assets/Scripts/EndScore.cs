using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScore : MonoBehaviour
{
    int? score = 100;
    TextMeshProUGUI scoreText;
    void Start(){
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.SetText($"Your Score: {score}");
    }
    void OnEnable() {
        score = PlayerPrefs.GetInt("score");
        if(score == null){
            score = 0;
        }
        
    }
    
}
