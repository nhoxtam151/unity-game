using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {   

        

        objects = GameObject.FindGameObjectsWithTag("Enemy");
        //GameObject.Find("Cube").SetActive(false);

        foreach(GameObject obj in objects)
        {
            obj.SetActive(false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
