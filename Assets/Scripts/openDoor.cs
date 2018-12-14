using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
    bool getkey;
    GameObject door;

	// Use this for initialization
	void Start () {
        getkey = false;
	}
	
	// Update is called once per frame
	void Update () {
   
	}
    public void havingKey()
    {
        getkey = true;
    }
    private void OnTriggerEnter2D(Collider2D co)
    { door = GameObject.FindGameObjectWithTag("Door");
        if (getkey == true & co.tag =="Door" )
        {
            Destroy(co.gameObject);
            getkey = false;
        }
    }
}
