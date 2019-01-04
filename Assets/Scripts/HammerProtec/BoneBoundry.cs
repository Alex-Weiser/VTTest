using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneBoundry : MonoBehaviour {
    public GameObject spawn; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "YardWall")
        {
            this.gameObject.transform.position = spawn.transform.position; 
            
        }
    }
}
