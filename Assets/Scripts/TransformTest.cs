using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {   //transform.up -> y axis
        //transform.forward -> z axis
        //transform.right -> x axis
        GetComponent<Renderer>().material.color = Color.red;
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed;
        transform.Rotate(speed, 0, 0);
    }
}
