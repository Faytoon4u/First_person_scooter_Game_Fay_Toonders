using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RabbitMoving : MonoBehaviour


{
    public NavMeshAgent Rabbit;
    //public float squareOfMovement = 20f;
    private float xMin;
    private float xMax;

    private float zMin;
    private float zMax;

    private float xPosition;
    private float zPosition;
    private float yPosition;

    public float CloseEnough;
    private Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        xMin = 46;
        zMin = -16; 
        xMax = 113;
        zMax = -125;

        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) <= CloseEnough) //makes it go to a new location if its close enough or at the other loc
        {
            newLocation();
        }

    }

    public void newLocation()
    { 
        yPosition = transform.position.y;
        xPosition = Random.Range(xMin, xMax);
        zPosition = Random.Range(zMin, zMax);

        Rabbit.SetDestination(new Vector3(xPosition, yPosition, zPosition));
        Animator anim = Rabbit.GetComponent<Animator>();
        anim.SetTrigger("Run");
    }

}
