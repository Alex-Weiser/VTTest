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
        if(other.gameObject.tag == "Hammer") {
            Instantiate(blood, transform.parent.position, Quaternion.identity);
            Destroy(gameObject);
}
    }
}
