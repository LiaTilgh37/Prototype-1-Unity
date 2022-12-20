using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // creates a player object
    private Vector3 offset = new Vector3(0, 5, -7); // Vector3 is x, y, and z (the 3 different coordinates of an object)

    void Start()
    {
        
    }

    void LateUpdate() // LateUpdate ends up smoothing the camera because it happens afterwards
    {
        // offsets the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}