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
        for (int j = 0; j < 10; j++)
        {
            print(Random.Range(1, 10));
        }

        for (int i = 0; i < 20; i++)
        {
            Instantiate(enemeyPrefab, spawnPoint.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
