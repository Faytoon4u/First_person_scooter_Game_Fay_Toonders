using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour


{
    public NavMeshAgent BadGuy;
    public float squareOfMovement = 20f;
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
        xMin = -squareOfMovement;
        zMin = -squareOfMovement;
        xMax = squareOfMovement;
        zMax = squareOfMovement;

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

        BadGuy.SetDestination(new Vector3(xPosition, yPosition, zPosition));
        Animator anim = BadGuy.GetComponent<Animator>();
        anim.SetTrigger("Rabbit@Run");
    }

}
