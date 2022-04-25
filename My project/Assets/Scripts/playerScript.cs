using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer = new Player("Hunter");
    private Rigidbody rb;
    public float speed = 20f;
    private int count = 0;
    private int destroyCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        CORE.setPlayer(thePlayer);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(CORE.getRoom());
            CORE.setDestroyCount(destroyCount);
            destroyCount++;
            count++;
            if (count == 14)
            {
                this.thePlayer.addKill();
                print("Kill Count: " + this.thePlayer.getKillCount());
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        //print(thePlayer.getName());
        if (Input.GetKey("w"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKey("d"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
    }
}