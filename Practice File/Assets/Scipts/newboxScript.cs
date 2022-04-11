using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newboxScript : MonoBehaviour
{
    public GameObject thePlayer;
    private int count;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 20f;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.speed = 10f;
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

   
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(thePlayer.transform.position);
    }
}
