using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDestroyer : MonoBehaviour
{
    GameObject[] monsters;
    GameObject[] geo;
    GameObject[] door;
   

   void OnTriggerEnter2D(Collider2D co)

    {
        monsters = GameObject.FindGameObjectsWithTag("Monster");
        geo = GameObject.FindGameObjectsWithTag("Ground");
        door = GameObject.FindGameObjectsWithTag("Door");
        if(co.tag == "Monster" || co.tag == "Ground"||co.tag=="Door")
        {
            Destroy(gameObject);
        }
        
    }


















}
