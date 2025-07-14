using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator to0pen;

    void Start()
    {
        button.enabled = false;
    }
    private void OnTriggerEnter(Collider other){
        button.enabled = true;
        to0pen.enabled = true;
    }
    }
