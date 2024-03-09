using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentScript : MonoBehaviour
{
    PlayerHealth health;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.useGravity = true;
        GetComponent<Renderer>().material.color = Color.red;
        health = GetComponent<PlayerHealth>();
        health.lives--;

        //GetComponentInChildren<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
