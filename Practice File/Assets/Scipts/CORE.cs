using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemeyPrefab;
    public Transform spawnPoint;

    //private static List<GameObject> theEnemies = new List<GameObject>();

    private static List<GameObject> theRooms = new List<GameObject>();

 

    public static void display()
    {
        print("stop that!");
    }

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void addCubes(GameObject cube)
    {
        //CORE.theEnemies.Add(cube);
        //print("I AM HERE");
    }


  

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Transform t = Instantiate(enemeyPrefab, spawnPoint.position, Quaternion.identity);
            Rigidbody rb = t.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(Random.Range(10, 30), Random.Range(0, 20), Random.Range(10, 30));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
