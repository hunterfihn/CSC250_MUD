using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    private int count;
    private Rigidbody erb;
    public float espeed = 20f;
    public Vector3 Movement;
    

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0; 
        erb = this.gameObject.GetComponent<Rigidbody>();
        Movement = new Vector3(Random.Range(-5.0f, 5.0f), 0.0f, Random.Range(-5.0f, 5.0f));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if (count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(true)
        {
            erb.velocity = Movement;
        } 

    }
}