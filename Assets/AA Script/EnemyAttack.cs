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
    private Vector2 playerXZ;
    private Vector2 enemyXZ;

    private void Awake()
    {
        enemyMovement = GetComponent<EnemyMovement>();
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        playerXZ = new Vector2(player.transform.position.x, player.transform.position.z);
        enemyXZ = new Vector2(transform.position.x, transform.position.z);


        if (Vector2.Distance(enemyXZ, playerXZ) <= attackRange)
        {
            enemyMovement.BadGuy.SetDestination(player.position);
            foundPlayer = true;
            enemyMovement.BadGuy.speed = 5f;
        }
        else if (foundPlayer)
        {
            enemyMovement.newLocation();
            foundPlayer = false;
            enemyMovement.BadGuy.speed = 5f;
        }
    }
}
