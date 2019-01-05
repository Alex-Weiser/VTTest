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
    public bool afterBoneDrop = false;

    public GameObject moveBack;
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
        if(other.gameObject.tag == "Yard" && dogScript.fetchCD == false)
        {
           // get bone
            pugAI.SetDestination(gameObject.transform.position);
            // set the boolean to false so the dog will move backwards once
            afterBoneDrop = false;
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dogScript.hasBone = false;
            boneRB.useGravity = true;
            //pugAI.SetDestination (new Vector3(Dog.transform.position.x,Dog.transform.position.y,Dog.transform.position.z + 1))
            if (!afterBoneDrop)
            {
                afterBoneDrop = true;
                pugAI.SetDestination(Dog.transform.position - Dog.transform.forward * 1);
            }
        }
    }
    public void ReturnBone()
    {
        pugAI.SetDestination(Player.transform.position);
       if (boneRB == null)
        {
           boneRB = this.gameObject.GetComponent<Rigidbody>();
       }
        boneRB.useGravity = false;
        boneRB.velocity = new Vector3(0,0,0);
        boneRB.rotation = Quaternion.identity; 
       

    }
}
