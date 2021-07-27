using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Variables : MonoBehaviour
{
    public float speed = 8f;

    public float getSpeed() {
        return speed;
    }

    public void EndScene(){
        SceneManager.LoadScene("EndMenu");
    }

    public void increaseSpeed(){
        speed += 1f;
    }
}
