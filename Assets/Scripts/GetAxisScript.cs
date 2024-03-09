using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GetAxisScript : MonoBehaviour
{
    public float speed;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xInput, yInput, 0);

        if(Input.GetMouseButtonDown(0))
        {
            print("Left click at position " + Input.mousePosition.x + " " + Input.mousePosition.y);

            Vector3 pos = Input.mousePosition;
            //pos have to be positive, if it is negative then it will appear behind the camera
            pos.z = 1f;
            pos = Camera.main.ScreenToWorldPoint(pos);
            print("World point: " + pos);

            Instantiate(obj, pos, Quaternion.identity);
        }

        if(Input.GetMouseButtonDown(1))
        {
            print("Right click at position " + Input.mousePosition.x + " " + Input.mousePosition.y);
        }

        if (Input.GetMouseButtonDown(2))
        {
            print("Wheel click at position " + Input.mousePosition.x + " " + Input.mousePosition.y);
        }

        
    }
}
