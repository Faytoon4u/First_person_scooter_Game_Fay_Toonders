using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostAttack : MonoBehaviour
{
    private ghostMovement ghostMovement;
    //public GameObject player;
    private Transform player; 
    public float attackRange = 10f;
    public Material defaultMaterial;
    public Material attackMaterial;
    private Renderer rend;
    public bool foundPlayer;
    private Vector2 playerXZ;
    private Vector2 enemyXZ;
    private float attackTimer;
    private float attackRate = 1f;
    [SerializeField] private int HP = 100;
    public float killRange = 3f;
    public Transform target;

    private Animator anim;
    private bool hasAttacked;

    private void Awake()
    {
        ghostMovement = GetComponent<ghostMovement>();
        rend = GetComponent<Renderer>();
        
    }

    void Update()
    {
        attackTimer += Time.deltaTime;
        playerXZ = new Vector2(player.transform.position.x, player.transform.position.z);
        enemyXZ = new Vector2(transform.position.x, transform.position.z);
        float dist = (Vector2.Distance(enemyXZ, playerXZ));


        if (Vector3.Distance(target.position, transform.position) <= attackRange) 
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
        if (Vector2.Distance(enemyXZ, playerXZ) <= killRange)
        {
            if(attackTimer > attackRate)
            {
                player.GetComponent<playerHealth>().takeDamage();   
                attackTimer = 0; // resets timer
                //Debug.Log("Ya got you");
            }

        }
    }
}
