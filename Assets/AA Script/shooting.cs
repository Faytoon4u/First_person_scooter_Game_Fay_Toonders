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
        if (Input.GetMouseButtonDown(0)) // this is the right mouse klik
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit))
            {
               if (hit.collider.tag.Equals("npc"))
               {
                    hit.collider.GetComponent<Enemyhealth>().Die();
                    hit.collider.GetComponent<Enemyhealth>().DieGhost();
                }
            }
            
        }

    }
}
