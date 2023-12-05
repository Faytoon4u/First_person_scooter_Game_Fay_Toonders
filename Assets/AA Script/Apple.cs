using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public int rewardAmount = 10; // how many apples there are in the applle area

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            // Call a method to handle the reward
            //HandleReward();

            Destroy(gameObject);
        }
    }

    private void HandleReward()
    {
        // Implement your reward system logic here
        // For example, you can increase the player's score, give them points, or trigger some other event.
        ScoreManager.Instance.AddScore(rewardAmount);
    }

}
