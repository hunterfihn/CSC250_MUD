using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer;
    private Rigidbody rb;
    public float speed = 20f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Mike");
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            count++;
            if (count == 3)
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
        else if (Input.GetKey("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
    }
}