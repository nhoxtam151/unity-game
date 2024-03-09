using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    public float speed;
    public int jumpHeight;
    bool jump = false;
    Rigidbody rigidbody;


    public float bulletSpeed;
    bool shoot = false;
    public GameObject bullet;
    public Transform bulletPos;
   
    

    float xInput;
    float yInput;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        if(Input.GetMouseButtonDown(0))
        {
            shoot = true;
        }
    }

    // Update is executed each frame;
    // FixedUpdate is executed at a specific rate defined in the editor;
    // and LateUpdate is executed after all the Update functions have been called
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(xInput * speed, rigidbody.velocity.y, yInput * speed);

        if(jump)
        {
            Jump();
            jump = false;
        }

        if(shoot)
        {
            Shoot();
            shoot = false;
        }
    }

    void Jump()
    {
        rigidbody.AddForce(0, jumpHeight, 0);
    }

    void Shoot()
    {
        GameObject bulletSpawn = Instantiate(bullet, bulletPos.position, bullet.transform.rotation);
        bulletSpawn.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);
                                    
    }
}
