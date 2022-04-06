using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newboxScript : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                this.gameObject.SendMessage("DoSomething");
               Destroy(this.gameObject);
            }
        }
        

    }

    /*
    void OnCollisionExit(Collision collision)
    {
        print("box collision exit");
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
