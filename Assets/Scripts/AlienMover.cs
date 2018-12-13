using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMover : MonoBehaviour
{

    public Transform[] waypoints;
    int cur = 0;
    public float speed = 0.1f;
    GameObject[] laser;
    int Hp = 5;
    GameObject gc;



    void FixedUpdate()
    {
        if (Hp == 0)
        {
            gc = GameObject.FindGameObjectWithTag("GameController");
            Destroy(gameObject);
            gc.GetComponent<GameController>().AddScore(5);
        }
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);

        }
       

        // Waypoint reached, select next one


        else
            cur = (cur + 1) % waypoints.Length;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        laser = GameObject.FindGameObjectsWithTag("Laser");
        if (collision.tag == "Laser")
        {
            Hp--;
            
        }
    }

}