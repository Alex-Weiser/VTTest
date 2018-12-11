using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EZCameraShake;
public class HammerHit : MonoBehaviour {
    public float Magnitude = 0.1f;
    public float Roughness = 15f;

    private CameraShakeInstance camShakeInstance;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            camShakeInstance = CameraShaker.Instance.ShakeOnce(Magnitude, Roughness, 0, 1f);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
