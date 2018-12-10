using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EZCameraShake;

public class TimerShake : MonoBehaviour {

    public float Magnitude = 0.5f;
    public float Roughness = 15f;
    public float FadeOutTime = 0.2f;

    private CameraShakeInstance camShakeInstance;
    private bool hasShakeStarted = false;

    public VrTimer timerScript;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timerScript.timerVariable < 10 && !hasShakeStarted)
        {
            hasShakeStarted = true;
            camShakeInstance = CameraShaker.Instance.StartShake(Magnitude, Roughness, 0);
        }

        if (timerScript.timerVariable <= FadeOutTime)
        {
            camShakeInstance.StartFadeOut(FadeOutTime);
        }
    }
}
