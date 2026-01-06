using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    float xvel, yvel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;
        if (Input.GetKey("a"))
        {
            xvel = -1;
        }
        if(Input.GetKey("d"))
        {
            xvel = 1;
        }
        if(Input.GetKey("w"))
        {
            yvel = 1;
        }
        if(Input.GetKey("s"))
        {
            yvel = -1;
        }
        rb.linearVelocity = new Vector3(xvel, yvel);
    }
}
