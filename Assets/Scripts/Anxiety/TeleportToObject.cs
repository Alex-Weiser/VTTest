using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToObject : MonoBehaviour {

	[Tooltip("Teleport to the location of this object")]
	public GameObject teleportDestinationObject;

    // Transport the player somewhere else
	void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player entered teleportation trigger");
            other.gameObject.transform.position = teleportDestinationObject.transform.position;
            other.gameObject.transform.rotation = teleportDestinationObject.transform.rotation;
        }
    }

}
