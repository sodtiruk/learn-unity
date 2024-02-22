using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 5f;
    public float speed = 3f;
    public int score = 0;
    void Start()
    {
        //find component in redballobject
        rb = GetComponent<Rigidbody>();
        

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            //short hand
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        

        }        


    }
    void FixedUpdate()
    {
             
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //short hand easier than
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);

        }        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left* speed, ForceMode.Impulse);

        }        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward* speed, ForceMode.Impulse);

        }        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed, ForceMode.Impulse);

        }        
        
            
    }
    void OnCollisionEnter(Collision collision)
    {
        score++;
        print(collision.gameObject.name + " " + collision.relativeVelocity.magnitude);
        /*if (collision.relativeVelocity.magnitude > 10)
        {
            Destroy(this.gameObject);
        } 
        */
         





    }

}
