using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCaseTest : MonoBehaviour
{
    public int power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(power)
        {
            case 1:
                print("You are Beginner Level");
                break;
            case 2:
                print("You are Intermediate Level");
                break;

            case 3:
                print("Your are an Advanced Level");
                break;
            default:
                print("You are not a player");
                break;
        }
    }
}
