using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaner : MonoBehaviour
{
    public GameObject OGEnemy;
    public int enemeyMax;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < enemeyMax; i++)
        {
            GameObject enemy = Instantiate(OGEnemy, transform.position, Quaternion.identity);

        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
