using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the score
        score = 0;
        UpdateScoreText();

        // Subscribe to the GhostController event
        ghostHealth.OnGhostClicked += HandleGhostClicked;
    }

    // Update is called once per frame
    void Update()
    {
        // You can add additional logic here if needed
    }

    // Handle the GhostClicked event
    void HandleGhostClicked(GameObject ghost)
    {
        // Increment the score when a ghost is clicked
        score++;
        UpdateScoreText();

        // You can add more logic here if needed
    }

    // Update the UI text with the current score
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    // Unsubscribe from the GhostController event when the script is disabled or destroyed
    private void OnDisable()
    {
        ghostHealth.OnGhostClicked -= HandleGhostClicked;
    }

    private void OnDestroy()
    {
        ghostHealth.OnGhostClicked -= HandleGhostClicked;
    }
}

