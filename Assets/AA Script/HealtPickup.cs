//using UnityEngine;

//public class HealthPickup : MonoBehaviour
//{
//    public float healthToAdd = 5f; // Amount of health to add per second
//    public float detectionRange = 2f; // Distance for detection

//    private void Update()
//    {
//        // Detect the player within the specified range
//        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRange);

//        foreach (Collider collider in colliders)
//        {
//            if (collider.CompareTag("HealthPickup"))
//            {
//                // Assuming the player has a script/component managing their health
//                playerHealth healthManager = collider.GetComponent<playerHealth>();

//                if (healthManager != null)
//                {
//                    // Increase player's health over time
//                    healthManager.AddHealth(healthToAdd * Time.deltaTime);
//                    Debug.Log("Health added to player.");
//                }
//                else
//                {
//                    Debug.LogWarning("Player does not have playerHealth script.");
//                }
//            }
//            else
//            {
//                Debug.LogWarning("Collider does not have 'HealthPickup' tag.");
//            }
//        }
//    }
//}
