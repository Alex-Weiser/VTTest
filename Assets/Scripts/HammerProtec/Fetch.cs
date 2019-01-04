using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Fetch : MonoBehaviour {
    public NavMeshAgent pugAI;
    public GameObject Dog;
    public Doggo dogScript;
    public GameObject Player;
    public Rigidbody boneRB;
	// Use this for initialization
	void Start () {
        pugAI = GameObject.FindGameObjectWithTag("Dog").GetComponent<NavMeshAgent>();
        Dog = GameObject.FindGameObjectWithTag("Dog");
        dogScript= GameObject.FindGameObjectWithTag("Dog").GetComponent<Doggo>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Player == null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }

        if (dogScript.hasBone == true)
        {
            ReturnBone();
           
        }
        if (dogScript.hasBone == false)
        {
            gameObject.transform.parent = null; 
        }
	}
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Yard")
        {
           // get bone
            pugAI.SetDestination(gameObject.transform.position); 
        }
        if(other.gameObject.tag == "Player")
        {
            dogScript.hasBone = false; 
        }
    }
    public void ReturnBone()
    {
        pugAI.SetDestination(Player.transform.position);
       // if (boneRB = null)
        //{
            //boneRB = this.gameObject.GetComponent<Rigidbody>();
      //  }
        //boneRB.useGravity = false;
        dogScript.hasBone = false; 
       

    }
}
