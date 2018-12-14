using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShootLaser : MonoBehaviour {

    public GameObject laser;
    public GameObject laserSpawn;
    GameObject player;
    float firerate = 2.0f;
    private float mytime = 0f;




    // Use this for initialization
    void Start () {
        player = GameObject.Find("Astronaut");
        Vector2 zp = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.Find("Astronaut");
        Vector2 zp = transform.position;
        mytime += Time.deltaTime;

        if (Mathf.Abs(zp.x-player.transform.position.x)<30&&mytime>firerate)
        {
            Instantiate(laser,laserSpawn.transform.position, laserSpawn.transform.rotation);
            mytime = 0f;
        }
		
	}
}
