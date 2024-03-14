using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator elevatorAnimator;
    public AudioSource sfx;
    public int floor = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        elevatorAnimator.SetInteger("AtFloor", floor);
        if (sfx != null)
        {
            sfx.Play();
        }
    }

}
