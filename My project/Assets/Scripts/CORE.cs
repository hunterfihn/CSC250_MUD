using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
    }

    // Start is called before the first frame update
    void Start()
    {
       /* for (int i = 0; i < 20; i++)
        {
            Transform t = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            Rigidbody rb = t.gameObject.GetComponent<Rigidbody>();
        } */
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

