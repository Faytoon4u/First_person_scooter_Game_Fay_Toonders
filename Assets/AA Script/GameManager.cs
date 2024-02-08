using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance

    public int totalRabbits;
    public int totalGhosts;

    private int rabbitsKilled = 0;
    private int ghostsKilled = 0;

    // Awake is called before Start and is used for setting up the singleton instance
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize totalRabbits and totalGhosts with the actual number of rabbits and ghosts in your scene
        // For example, you might find them using GameObject.FindGameObjectsWithTag
        // totalRabbits = GameObject.FindGameObjectsWithTag("Rabbit").Length;
        // totalGhosts = GameObject.FindGameObjectsWithTag("Ghost").Length;

        // You can also set these values manually if you know the counts beforehand
    }

    // Method to be called when a rabbit is killed
    public void RabbitKilled()
    {
        rabbitsKilled++;
        CheckWinCondition();
    }

    // Method to be called when a ghost is killed
    public void GhostKilled()
    {
        ghostsKilled++;
        CheckWinCondition();
    }

    // Check if the win condition is met
    void CheckWinCondition()
    {
        if (rabbitsKilled >= totalRabbits && ghostsKilled >= totalGhosts)
        {
            // All rabbits and ghosts are killed, go to the winning scene
            SceneManager.LoadScene("WinningScene"); // Replace "WinningScene" with the actual name of your winning scene
        }
    }
}
