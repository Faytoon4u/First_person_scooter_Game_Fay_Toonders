using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IndividualGhostController : MonoBehaviour
{
    private void OnEnable()
    {
        ghostHealth.OnGhostClicked += HandleGhostClicked;
    }

    private void OnDisable()
    {
        ghostHealth.OnGhostClicked -= HandleGhostClicked;
    }

    void HandleGhostClicked(GameObject ghost)
    {
        if (gameObject == ghost)
        {
            // Destroy the clicked ghost
            Destroy(gameObject);
        }
    }
}
