using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float lifeTime = 45;
    public float heatPower = 0.1f;

    void Update()
    {
        lifeTime -=Time.deltaTime;
        if(lifeTime <= 0){
            gameObject.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other){
         if (other.GetComponent<Temperature>() != null){
            Temperature temp = other.GetComponent<Temperature>();
            if (temp.temp_now < temp_norm){
                temp.temp_now += heatPower*Time.deltaTime;
            }
         }
    }
}
