using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealingPool : MonoBehaviour
{
    public Slider healthSlider;
    public int maxHealth = 40;
    public int health = 1;
    public float healAmount = 5;
    public float timeBetweenHits = 2f;
    // Start is called before the first frame update
    void Start()
    {
        if (healthSlider == null)
        {
            Debug.Log("Slider not assigned");
        }

        //healthSlider.maxValue = maxHealth;
        //healthSlider.value = health;
    }
    public void takeHealth()
    {
        //if (health <= 0)
        //{
        //    Debug.Log(health + "You died");
        //    //Dead.gameObject.SetActive(true);
        //    //UpdateCursorState();
        //}

        //else
        //{
        //    health += 5;
        //    healthSlider.value = health;
        //    Debug.Log(health);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            health += 5;

        }
    }
}
