using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TImer : MonoBehaviour
{
    public int min;
    public float sec;

    void Update()
    {
        sec -= Time.deltaTime;
        if(sec <= 0){
            if(min > 0){
                sec += 59;
                min--;
            }
            else{
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}
