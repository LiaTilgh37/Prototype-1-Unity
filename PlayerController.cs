using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour // colon indicates inheritance
{
    private float speed = 10.0f; // vehicle speed
    private float turnSpeed = 25.0f; // rotation speed
    private float horizontalInput; // left & right input
    private float forwardInput; // forward & backwards input

    public Camera mainCamera; // full visualization
    public Camera hoodCamera; // close-up of the road
    public KeyCode switchKey; // var to switch between cams

    public string inputID; // because we have to different players in the game

    // called before the first frame update; for when you press play on the game
    void Start()
    {
        
    }

    // called once per frame; constantly checking for different calculations, like a box colliding w/ something else
    void Update()
    {
        // player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // moves the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey)) // if statement to switch between cameras; idk why it's not working on the game yet??
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}