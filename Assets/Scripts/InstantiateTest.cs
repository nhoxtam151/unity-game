using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InitRandomBall", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Mouse Clicked");
            CancelInvoke("InitRandomBall");
        }
    }

    void InitRandomBall()
    {
        int randomNumber = Random.Range(0, objs.Length);
        Instantiate(objs[randomNumber], transform.position, Quaternion.identity);
    }
}
