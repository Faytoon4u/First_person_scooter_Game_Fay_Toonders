using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
   
    public Slider healthSlider;
    public int maxHealth = 40;
    public int health;
    public float healAmount = 5;
    public float timeBetweenHits = 2f;
    


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;

        if(healthSlider == null)
        {
            Debug.Log("Slider not assigned");
        }

        
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
    }
    public void Update()
    {

    }
    public void takeDamage()
    {
        if (health <= 0)
        {
            Debug.Log(health + "You died");

        }

        else
        {
            health--;
            healthSlider.value = health;
            Debug.Log(health);
        }
    }

    //void UpdateCursorState()
    //{
    //    Time.timeScale = 1;
    //    Cursor.visible = true;
    //    Cursor.lockState = CursorLockMode.None;
    //}

}

