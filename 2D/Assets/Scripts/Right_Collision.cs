using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Collision : MonoBehaviour
{
    public Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    }

}
