using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;


    private Ray ray;
    private RaycastHit hit;
    public Animator anim;


    // Update is called once per frame
    void Update()
    {
            
            if (Input.GetMouseButtonDown(0))
            {
                ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("npc"))
                    {
                        // Assuming Enemyhealth script is attached to the enemy
                        hit.collider.GetComponent<Enemyhealth>().Die();
                    }
                if (hit.collider.CompareTag("npc2"))
                {
                    // Assuming Enemyhealth script is attached to the enemy
                hit.collider.GetComponent<ghostHealth>().Die();
                }

            }
        }
        
    }

}

