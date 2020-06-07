using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject WallRight;
    public GameObject WallLeft;
    public GameObject WallUp;
    public GameObject WallDown;
    public float lifeTime = 1.0f;


    public bool Wallup = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && Wallup == false)
        {
            WallRightSpawn();
        }
        if (Input.GetKeyDown(KeyCode.A) && Wallup == false)
        {
            WallLeftSpawn();
        }
        if (Input.GetKeyDown(KeyCode.W) && Wallup == false)
        {
            WallUpSpawn();
        }
        if (Input.GetKeyDown(KeyCode.S) && Wallup == false)
        {
            WallDownSpawn();
        }
    }



    void WallRightSpawn()
    {
        Instantiate(WallRight);
        Wallup = true;
    }
    void WallLeftSpawn()
    {
        Instantiate(WallLeft);
        Wallup = true;
    }
    void WallUpSpawn()
    {
        Instantiate(WallUp);
        Wallup = true;
    }
    void WallDownSpawn()
    {
        Instantiate(WallDown);
        Wallup = true;
    }


}
