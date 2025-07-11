using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip damageSound;
    public int currenthealth = 10;
    public int maxHealth = 10;
    public void TakeDamge(int damage)
    {
        currenthealth -= damage;
        if (currenthealth > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}