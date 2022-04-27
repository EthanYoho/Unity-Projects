using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;
  
    // Start is called before the first frame update
    void Awake()
    {
        print("Room trigger is awake");
    }
    void Start()
    {
        
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
        
        
    }

    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(CORE.getPlayer()); // lets the new room know about the player
            print("PLayer now here in " + this.thisRoom);
            Destroy(CORE.getRoom());

        }
        else if(other.gameObject.tag.Equals("Enemy"))
        {
            this.thisRoom.setEnemy(CORE.getEnemy());
            print("Enemy now here in" + this.thisRoom);
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
