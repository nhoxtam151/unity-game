using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FirstScript : MonoBehaviour
{
    public bool killPlayer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed, 0, 0);
        if(killPlayer)
        {   
            //gameObject means the current object attached this script
           Destroy(gameObject, 3f);
        }
    }

    private void OnEnable()
    {
       
    }

    private void OnDisable()
    {
       
    }


}
