using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncomingVehicles : MonoBehaviour
{
    private float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}