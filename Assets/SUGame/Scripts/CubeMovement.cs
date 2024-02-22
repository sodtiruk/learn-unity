using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    float up = 0.0f;
    float spin = 0.0f;
    public float x_value;
    public float multipier;
    public float holizontal = 0.0f;
    public float vertical = 0.0f;
    public float speed = 0.1f;
    public float height = 1f;


    // Start is called before the first frame update
    void Start()
    {
        print("hello world");  
    }

    // Update is called once per frame
    void Update()
    {
        up += 0.001f;
        spin += 0.1f;
        //x_value += 0.1f;
        // transform.position = new Vector3(Mathf.Sin(x_value) * multipier, up, Mathf.Cos(x_value) * multipier);
        //transform.rotation = Quaternion.Euler(0, spin, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            holizontal -= speed * Time.deltaTime;
        }           
        if (Input.GetKey(KeyCode.RightArrow))
        {
            holizontal += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vertical += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vertical -= speed *Time.deltaTime;
        }

        transform.position = new Vector3(holizontal, height, vertical);






    }
}
