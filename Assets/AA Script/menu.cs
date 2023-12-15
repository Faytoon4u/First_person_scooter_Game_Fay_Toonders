using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private int GameMode;

    public void PLayGame(int gameMode)
    {
        if (GameMode == 0)
        {
            SceneManager.LoadScene("GAME");
        }

        if (GameMode == 0)
        {
            SceneManager.LoadScene("play 1");
        }

        if (GameMode == 0)
        {
            SceneManager.LoadScene("play 3");
        }
    }










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
