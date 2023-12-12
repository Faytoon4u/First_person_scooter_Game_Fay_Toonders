using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ghostMovement : MonoBehaviour

{
    public float squareOfMovement = 20f;
    private float xMin;
    private float xMax;

    private float zMin;
    private float zMax;

    private float xPos;
    private float yPos;
    private float zPos;

    public float closeEnough = 2f;
    private Animator anim;

    public NavMeshAgent BadGuy;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        xMin = -128;
        zMin = 108; 
        xMax = -32;
        zMax = -90;

        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(xPos, zPos)));
        // if they get close enough to their location they get a new location to go to
        if (Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(xPos, zPos)) <= closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        //gets random cordinates to walk to
        xPos = Random.Range(xMin, xMax);
        yPos = Terrain.activeTerrain.SampleHeight(new Vector3(xPos, 0f, zPos));
        zPos = Random.Range(zMin, zMax);
        BadGuy.SetDestination(new Vector3(xPos, yPos, zPos));
        anim.Play("Idle");
    }
}
