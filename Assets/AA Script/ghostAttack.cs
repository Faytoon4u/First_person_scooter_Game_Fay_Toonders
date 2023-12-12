using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostAttack : MonoBehaviour
{
    private ghostMovement ghostMovement;
    private Transform player;
    public float attackRange = 10f;
    public Material defaultMaterial;
    public Material attackMaterial;
    private Renderer rend;
    public bool foundPlayer;
    private Vector2 playerXZ;
    private Vector2 enemyXZ;

    public float killRange = 3f;
 
    private Animator anim;
    private bool hasAttacked;

    private void Awake()
    {
        ghostMovement = GetComponent<ghostMovement>();
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        playerXZ = new Vector2(player.transform.position.x, player.transform.position.z);
        enemyXZ = new Vector2(transform.position.x, transform.position.z);


        if (Vector2.Distance(enemyXZ, playerXZ) <= attackRange)
        {
            ghostMovement.BadGuy.SetDestination(player.position);
            foundPlayer = true;
            ghostMovement.BadGuy.speed = 5f;
        }
        else if (foundPlayer)
        {
            ghostMovement.newLocation();
            foundPlayer = false;
            ghostMovement.BadGuy.speed = 5f;
        }
        // Attack the player when within killRange
        //if (Vector2.Distance(enemyXZ, playerXZ) <= killRange)
        //{
        //    // Check if an attack has already been initiated
        //    if (!hasAttacked)
        //    {
        //        anim.Play("attack");
        //        //player.GetComponent<playerHealth>().takeDamage();
        //        hasAttacked = true;
        //    }
        //}
        //else
        //{

        //    hasAttacked = false;
        //}
    }

    //private void OnTriggerEnter(Collider col)
    //{
    //    if (col.CompareTag("Player"))
    //    {
    //        player.GetComponent<playerHealth>().takeDamage();

    //    }
    //}
}
