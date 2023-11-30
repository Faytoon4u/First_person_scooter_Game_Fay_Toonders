using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private EnemyMovement enemyMovement;
    private Transform player;
    public float attackRange = 10f;
    public Material defaultMaterial;
    public Material attackMaterial;
    private Renderer rend;
    public bool foundPlayer;


    private void Awake()
    {
       enemyMovement = GetComponent<EnemyMovement>();
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = attackMaterial;
            enemyMovement.BadGuy.SetDestination(player.position);
            foundPlayer = true;
        }
        else if(foundPlayer)
        {
            rend.sharedMaterial = defaultMaterial;
            enemyMovement.newLocation();
            foundPlayer = false;
        }
    }
}
