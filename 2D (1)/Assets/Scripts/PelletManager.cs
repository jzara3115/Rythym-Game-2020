using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletManager : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "MoveRight")
        {
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(speed, 0);
        }
        if (gameObject.tag == "MoveDown")
        {
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, -speed);
        }
        if (gameObject.tag == "MoveLeft")
        {
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-speed, 0);
        }
        if (gameObject.tag == "MoveUp")
        {
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, speed);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
