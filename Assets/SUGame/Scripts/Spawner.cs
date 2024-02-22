using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject original;
    public float power = 10;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 1; i++) { 

                GameObject table = Instantiate(original);
                table.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+i, this.transform.position.z);


                //set rigibody what is rigibody  >> rifidbody is gravity
                Rigidbody rb = table.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(0, 0, power, ForceMode.Impulse);
                } 


                //delete object table
                Destroy(table, 5f);


            }

        }
    }
}
