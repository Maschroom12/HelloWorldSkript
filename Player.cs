using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    public void TakeDamge(int damage){
        health -= damage;
        print("Здоровье игрока:" + health);
    }
}