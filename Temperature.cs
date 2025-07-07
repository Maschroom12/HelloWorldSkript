using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public int player_dmg = 2;
    public float temp_now = 36.6f;
    public float temp_norm = 36.6f;
    public float temp_critic = 34f;
    public float freeze_speed = 0.05f;
    public float frzDmgTimer = 1;
    public float frzDmgDelay = 2;

    void Update()
    {
        temp_now -= freeze_speed*Time.deltaTime;
        if(temp_now <= temp_critic){
            if(frzDmgTimer <= 0){
                health.TakeDamage(player_dmg);
                frzDmgTimer += frzDmgDelay;
            }
            else{
                frzDmgTimer -=Time.deltaTime
            }
        }
    }
}
