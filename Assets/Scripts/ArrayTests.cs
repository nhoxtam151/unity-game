using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTests : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;

    // Start is called before the first frame update
    void Start()
    {
        objects[0].GetComponent<Renderer>().material.color = colors[0];
        objects[1].GetComponent<Renderer>().material.color = colors[1];
        objects[2].GetComponent<Renderer>().material.color = colors[2];
        objects[3].GetComponent<Renderer>().material.color = colors[3];

        foreach(GameObject o in objects)
        {
            o.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
