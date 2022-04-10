using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newboxScript : MonoBehaviour
{
    public float speed = 4.0f;
    private Rigidbody rb;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        //CORE.addCubes(this.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
       

        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            if(count == 3)
            {
              
               Destroy(this.gameObject);
            }
        }
        

    }

    void randomMove()
    {
        int ran = Random.Range(1, 4);
        if (ran == 1)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else
        if (ran == 2)
        {
            rb.velocity = Vector3.right * speed;
        }
        else
        if (ran == 3)
        {
            rb.velocity = Vector3.back * speed;
        }
        else
        if (ran == 4)
        {
            rb.velocity = Vector3.left * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        randomMove();
    }
}
