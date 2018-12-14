using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP : MonoBehaviour
{

    public float speed = 10f;
    public float jumpForce = 700f;
   
    public GameObject laser;
    public GameObject laserSpawn;
    public float fireRate = 0.5f;
    bool facingRight = true;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    GameObject[] hazard;
    int hp;
    GameObject gc;
    




    private Rigidbody2D rb2d;
    private float myTime = 0f;
    Vector2 direction = Vector2.zero;


    // Use this for initialization
    void Start()
    {
        
      
        rb2d = GetComponent<Rigidbody2D>();
        hp = 100;

    }
    void updateHp()
    { }
    
    // Update is called once per frame
    void Update()
    {
      
        if(grounded && Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
        }
    
        



        myTime += Time.deltaTime;

      
        if (Input.GetButton("Fire1") && myTime > fireRate)
        {
            Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            myTime = 0.0f;


        }
       
        
        



     
        

    }

    void FixedUpdate()
    {

        
            if (hp <= 0)
            {
            gc.GetComponent<GameController>().GameOver();
            Destroy(gameObject);
        }






            grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
                                           
        float horiz = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");

      
        

       

        rb2d.velocity = new Vector3(horiz * speed, rb2d.velocity.y);
       

     
    }
   

    void OnTriggerEnter2D(Collider2D co)
    {
        gc = GameObject.FindGameObjectWithTag("GameController");
        hazard = GameObject.FindGameObjectsWithTag("Hazard");
        if (co.tag == "Hazard")
        {
            hp = 0;
            gc.GetComponent<GameController>().GameOver();

        }
        if (co.tag == "EnemyLaser")
        {
            hp = hp - 10;
            gc.GetComponent<GameController>().hpNumber(10);
        }
       

        
    }






}


