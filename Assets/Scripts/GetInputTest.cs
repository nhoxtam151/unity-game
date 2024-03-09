using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   


        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Space pressed");
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("Space is holding");     
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space released");
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
