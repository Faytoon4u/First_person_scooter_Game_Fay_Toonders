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

        //if (Input.GetKeyDown(KeyCode.E) && weaponSwitchScript.newSelectedWeapon == 4)
        //{
        //    if (health <= 49 && healAmount >= 1)
        //    {
        //        healAmount--;
        //        health += 5;
        //        healthSlider.value = health;
        //        Debug.Log("+5 health");
        //        GameObject.Find("VaccineVial_Purple").GetComponent<Animator>().Play("Healing");
        //        Instantiate(Sparkles, transform.position, Quaternion.identity);
        //    }
        //    else if (healAmount <= 0)
        //    {
        //        Destroy(healerVial);
        //        Debug.Log("You used all healing vials");
        //    }

        //    else
        //    {
        //        Debug.Log("You have enough health");
        //    }
        //}
    }
    public void takeDamage()
    {
        if (health <= 0)
        {
            Debug.Log(health + "You died");
            //Dead.gameObject.SetActive(true);
            //UpdateCursorState();
        }

        else
        {
            health--;
            healthSlider.value = health;
            Debug.Log(health);
        }
    }

    void UpdateCursorState()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}

