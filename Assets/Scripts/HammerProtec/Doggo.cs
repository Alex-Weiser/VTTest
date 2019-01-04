using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour {
    public GameObject hatPoint;
    public GameObject bonePoint; 
    bool hasHat = false;
    public bool hasBone = false;
	
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hat" && hasHat == false)
        {
            
            other.gameObject.transform.position = hatPoint.transform.position;
            other.gameObject.transform.rotation = hatPoint.transform.rotation; 
            other.gameObject.transform.parent = hatPoint.transform;
            hasHat = true; 
        }
        if (other.gameObject.tag == "Bone" && hasBone == false)
        {
            other.gameObject.transform.position = bonePoint.transform.position;
            other.gameObject.transform.rotation = bonePoint.transform.rotation;
            other.gameObject.transform.parent = bonePoint.transform;
            hasBone = true; 
        }
        
    }
}
