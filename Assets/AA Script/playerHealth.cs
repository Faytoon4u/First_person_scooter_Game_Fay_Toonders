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

        if (healthSlider == null)
        {
            Debug.Log("Slider not assigned");
        }

        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        // Add any necessary update logic here
    }

    public void takeDamage()
    {
        if (health <= 0)
        {
            Debug.Log(health + " You died");
        }
        else
        {
            health--;
            UpdateHealthSlider();
            Debug.Log("Health: " + health);
        }
    }

    public void AddHealth(float amount)
    {
        if (health + amount <= maxHealth)
        {
            health += Mathf.RoundToInt(amount);
        }
        else
        {
            health = maxHealth;
        }

        UpdateHealthSlider();
        Debug.Log("Health: " + health);
    }

    private void UpdateHealthSlider()
    {
        healthSlider.value = health;
    }
}
