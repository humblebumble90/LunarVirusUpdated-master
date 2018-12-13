using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour {
    GameObject gc;
    GameObject mc;


    private void OnTriggerEnter2D(Collider2D co)
    {
        gc = GameObject.FindGameObjectWithTag("GameController");
        mc = GameObject.FindGameObjectWithTag("Player");
        if (co.tag == "Player")
        {
            Destroy(co.gameObject);
            gc.GetComponent<GameController>().GameOver();
        }
       
        
    }


}
