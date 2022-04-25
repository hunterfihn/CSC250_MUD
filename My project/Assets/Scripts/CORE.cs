using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    private static List<GameObject> theRoomsGos = new List<GameObject>();
    private static List<Room> theRooms = new List<Room>();
    private static Player currentPlayer = null;
    private static Enemy currentEnemy = null;
    private static int destroyCount = 0;

    public static GameObject getRoom()
    {
        return CORE.theRoomsGos[destroyCount];
    }

    public static void setDestroyCount(int x)
    {
        destroyCount = x;
    }

    public static void setPlayer(Player p)
    {
        CORE.currentPlayer = p;
    }

    public static void setEnemy(Enemy e)
    {
        CORE.currentEnemy = e;
    }

    public static Player getPlayer()
    {
        return CORE.currentPlayer;
    }

    public static Enemy getEnemy()
    {
        return CORE.currentEnemy;
    }

    public static void addRoom(Room theRoom)
    {
        CORE.theRooms.Add(theRoom);
    }

    public static void addRoomGO(GameObject go)
    {
        CORE.theRoomsGos.Add(go);
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

