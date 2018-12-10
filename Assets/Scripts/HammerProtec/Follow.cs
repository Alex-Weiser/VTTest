using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour {
    private NavMeshAgent myNav;
    private Transform Player;

	// Use this for initialization
	void Start () {
        myNav = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag ("Target").GetComponent<Transform>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Player == null)
        {
            Player = GameObject.FindGameObjectWithTag("Target").GetComponent<Transform>();
        }

        // gameObject.transform.rotation = new Quaternion(0, 0, 0,0); 
        //transform.LookAt(Player.transform.position);
        myNav.SetDestination(Player.transform.position);
        
        
	}
}
