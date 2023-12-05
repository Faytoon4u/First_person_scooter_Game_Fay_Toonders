using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform Player;
    private float xMouse;
    private float yMouse;
    private float xRotation;
    public float speed = 100f; // the speed from the rotation movement



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //you dont see the cursor in playmode
    }

    // Update is called once per frame
    void Update()
    {
        xMouse = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        yMouse = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // not bending your nek to far. 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // for turing up and down
        Player.Rotate(Vector3.up * xMouse); 
    }

}
