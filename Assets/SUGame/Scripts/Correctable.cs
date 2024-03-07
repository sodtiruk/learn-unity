using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correctable : MonoBehaviour
{
    // Start is called before the first frame update
    public PlaygrouundManager manager;
    public int score = 100;
    void Start()
    {
        manager = FindObjectOfType<PlaygrouundManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "RedBall")
        {
            manager.playerScore += score;
            Destroy(gameObject);
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player") // check tag
        {
            manager.playerScore += score;
            Destroy(gameObject);
        } 
    }


}
