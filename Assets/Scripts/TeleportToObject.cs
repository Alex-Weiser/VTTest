using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToObject : MonoBehaviour {

	[Tooltip("Teleport to the location of this object")]
	public GameObject teleportDestinationObject;

	// Use this for initialization
	void Start () {
			Debug.Log("Started game.");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
			Debug.Log("Player entered trigger");
			other.gameObject.transform.position = teleportDestinationObject.transform.position;
            other.gameObject.transform.rotation = teleportDestinationObject.transform.rotation; 
    }

}
