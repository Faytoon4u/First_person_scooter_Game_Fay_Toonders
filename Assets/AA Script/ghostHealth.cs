using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostHealth : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //public void Die()
    //{
    //    Destroy(hit.collider.gameObject); // the GameObject gets destroyed here
    //    Debug.Log("hit");
    //    //Animator anim = GetComponent<Animator>();
    //    //anim.SetTrigger("dissolve");
    //    //DontDestroyOnLoad("Dead");
    //    StartCoroutine(Dead());
    //}
    //IEnumerator Dead()
    //{
    //    yield return new WaitForSeconds(1.4f);
    //    Destroy(gameObject);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    // Check if the left mouse button is clicked
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        // Raycast from the mouse position to detect if it hits the ghost
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;

    //        // Adjust the layer mask based on your ghost's layer
    //        int layerMask = LayerMask.GetMask("GhostLayer");

    //        // Perform the raycast
    //        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
    //        {
    //            // Check if the ray hit the ghost
    //            if (hit.collider != null && hit.collider.gameObject == gameObject)
    //            {
    //                // Ghost is clicked, so destroy it
    //                Destroy(gameObject);
    //            }
    //        }
    //    }
    //}
    // Update is called once per frame
    public delegate void GhostClicked(GameObject ghost);
    public static event GhostClicked OnGhostClicked;

    public void Die()
    {
        //Destroy(hit.collider.gameObject); // the GameObject gets destroyed here
        Debug.Log("hit");
        // DontDestroyOnLoad("Dead");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is clicked
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // Raycast from the mouse position to detect if it hits a ghost
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    // Adjust the layer mask based on your ghost's layer
        //    int layerMask = LayerMask.GetMask("GhostLayer");

        //    // Perform the raycast
        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        //    {
        //        Debug.Log("aw");

        //        // Check if the ray hit a ghost
        //        if (hit.collider.CompareTag("npc2"))
        //        {
        //            // Broadcast the event to notify that a ghost is clicked
        //            OnGhostClicked?.Invoke(hit.collider.gameObject);
        //            Destroy(gameObject);
        //        }
        //    }
        //}
    }
}
