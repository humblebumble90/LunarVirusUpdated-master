using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserDestroyer : MonoBehaviour
{
    GameObject[] monsters;
    GameObject[] geo;
    GameObject[] door;
   

   void OnTriggerEnter2D(Collider2D co)

    {
        GameObject player = GameObject.Find("Astronaut");
      
        geo = GameObject.FindGameObjectsWithTag("Ground");
        door = GameObject.FindGameObjectsWithTag("Door");
        if(co.tag == "Ground"||co.tag=="Door"||co.name=="Astronaut")
        {
            Destroy(gameObject);
        }
        
    }


















}
