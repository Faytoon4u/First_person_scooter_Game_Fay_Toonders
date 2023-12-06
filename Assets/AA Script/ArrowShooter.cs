using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{
    public GameObject arrowPrefab;  // Reference to the arrow prefab
    public Transform arrowSpawnPoint;  // The point from which the arrow will be spawned
    public float shootForce = 10f;  // The force applied to shoot the arrow

    void Update()
    {
        // Check for input to shoot the arrow
        if (Input.GetMouseButtonDown(0))
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // Instantiate a new arrow
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, Quaternion.identity);

        // Reset the arrow's rotation
        arrow.transform.rotation = Quaternion.identity;

        // Get the arrow's rigidbody
        Rigidbody arrowRb = arrow.GetComponent<Rigidbody>();

        // Apply force to shoot the arrow
        arrowRb.AddForce(arrowSpawnPoint.up * shootForce, ForceMode.Impulse);
    }
}

