using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableItem : MonoBehaviour
{
    // Start is called before the first frame update
    public PlaygrouundManager manager;
    public Rigidbody rb;
    public float breakValue = 10f;
    public int score = 100;


    void Start()
    {
        manager = FindObjectOfType<PlaygrouundManager>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= breakValue)
        {
            manager.playerScore += score;
            print(collision.gameObject.name + " " + collision.relativeVelocity.magnitude);
            Destroy(this.gameObject);
        } 
    }
}
