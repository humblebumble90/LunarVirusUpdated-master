using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDestroyer : MonoBehaviour
{
    GameObject[] monsters;
    GameObject[] geo;
   

   void OnTriggerEnter2D(Collider2D co)

    {
        monsters = GameObject.FindGameObjectsWithTag("Monster");
        geo = GameObject.FindGameObjectsWithTag("Ground");
        if(co.tag == "Monster" || co.tag == "Ground")
        {
            Destroy(gameObject);
        }
        
    }


















}
