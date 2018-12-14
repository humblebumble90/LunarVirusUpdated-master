using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healingshot : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D co)
    {
        GameObject player = GameObject.Find("Astronaut");
        GameObject gc = GameObject.Find("GameController");
        if (co.name == "Astronaut")
            gc.GetComponent<GameController>().AddHp();
        Destroy(gameObject);
        
    }
}