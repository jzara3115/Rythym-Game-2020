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
    public GameObject game_Over;

    public bool dead = false;
    public bool Wallup = false;
    public int hp = 3;


    void Awake()
    {
        this.gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (Wallup == true)
        {
            Invoke("RightActive", 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.D) && Wallup == false)
        {
            //WallRightSpawn();
            Wallup = true;
            this.WallRight.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.A) && Wallup == false)
        {
            //WallLeftSpawn();
            Wallup = true;
            this.WallLeft.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.W) && Wallup == false)
        {
            //WallUpSpawn();
            Wallup = true;
            this.WallUp.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.S) && Wallup == false)
        {
            //WallDownSpawn();
            Wallup = true;
            this.WallDown.SetActive(true);
        }

    }

    public void OnTriggerEnter2D (Collider2D died)
    {
        switch (hp)
        {
            case 3:
                hp= 2;
                Debug.Log("Hit once");
                break;
            case 2:
                hp = 1;
                Debug.Log("Hit Twice");
                break;
            case 1:
                hp = 0;
                dead = true;
                Debug.Log("Dead");
                this.game_Over.SetActive(true);
                //this.gameObject.SetActive(false);
                break;
        }
        Destroy(died.gameObject);
    }


public void RightActive()
    {
        Wallup = false;
        WallRight.SetActive(false);
        WallLeft.SetActive(false);
        WallUp.SetActive(false);
        WallDown.SetActive(false);
    }

}


/* void WallRightSpawn()
 {
     Wallup = true;
     this.WallRight.SetActive(true);
 }
 void WallLeftSpawn()
 {
     this.WallLeft.SetActive(true);
     Wallup = true;
 }
 void WallUpSpawn()
 {
     this.WallUp.SetActive(true);
     Wallup = true;
 }
 void WallDownSpawn()
 {
     this.WallDown.SetActive(true);
     Wallup = true;
 }*/


