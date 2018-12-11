using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSmash : MonoBehaviour {
    public GameObject blood;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("Scorpion hit by something");

        if(other.gameObject.tag == "Hammer") {
            Debug.Log("ENEMY DESTROYED!");
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
