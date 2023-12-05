using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    
        public static ScoreManager Instance;

        private int score = 0;

        private void Awake()
        {
            //////if (Instance == null)
            //////{
            //////    Instance = this;
            //////}
            //else
            {
                Destroy(gameObject);
            }
        }

        public void AddScore(int amount)
        {
            score += amount;
            // Update UI or perform other actions based on the new score
        }

        public int GetScore()
        {
            return score;
        }
    
}
