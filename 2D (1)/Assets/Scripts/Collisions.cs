using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Rigidbody2D rb;
    private Player player;

    void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //if (player.Wallup == true)
        //{ 
        //  Invoke("RightActive", 1);
        //}

    }

    /*  public void RightActive()
       {
           player.WallRight.SetActive(false);
           player.WallLeft.SetActive(false);
           player.WallUp.SetActive(false);
           player.WallDown.SetActive(false);
       }*/
}