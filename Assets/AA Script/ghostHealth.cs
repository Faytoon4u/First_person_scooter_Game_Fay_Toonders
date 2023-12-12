using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Die()
    {
        //Destroy(hit.collider.gameObject); // the GameObject gets destroyed here
        Debug.Log("hit");
        Animator anim = GetComponent<Animator>();
        anim.SetTrigger("dissolve");
        // DontDestroyOnLoad("Dead");
        StartCoroutine(Dead());
    }
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(1.4f);
        Destroy(gameObject);
    }
}
