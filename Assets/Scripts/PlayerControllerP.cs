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

        
            if (hp < 0)
            { Destroy(gameObject);
            }






            grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
                                           
        float horiz = Input.GetAxis("Horizontal");

      
        Vector2 movement = new Vector2(horiz, 0);

       

        rb2d.velocity = new Vector2(horiz * speed, rb2d.velocity.y);
        if (horiz > 0 && !facingRight)
            flip();
        else if (horiz < 0 && facingRight) 
        flip();

     
    }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale;


    }
    void OnTriggerEnter2D(Collider2D co)
    {
        gc = GameObject.FindGameObjectWithTag("GameController");
        hazard = GameObject.FindGameObjectsWithTag("Hazard");
        if (co.tag == "Hazard")
        {
            hp = hp - 1;
            Debug.Log(hp);
            gc.GetComponent<GameController>().hpNumber(1);
            
            
        }
       

        
    }






}


