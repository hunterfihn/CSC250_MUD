using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boxScript : MonoBehaviour
{
    private int count;
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 10.0f;
    private NavMeshAgent agent;
    private Enemy theEnemy = new Enemy("Enemy");

    void Start() //like a constructor
    {
        CORE.setEnemy(theEnemy);
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if (count == 14)
            {
                Destroy(this.gameObject);
            }
        }
    }

    /* public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    public Room getRoom()
    {
        return this.currentRoom;
    }
*/
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(thePlayer.transform.position);
    }
}