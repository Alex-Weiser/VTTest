using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VrTimer : MonoBehaviour {
    public Text timerText;
    public float timerVariable;
    public int textMaxSize;
    public float fontTimer;
    float fontInterval = 300;
    // Use this for initialization
    void Start () {
        timerVariable = 60;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(fontInterval);

        if (timerVariable < 0)
        {
            timerVariable = 0;
            timerText.text = "" + timerVariable;
        }
        if (timerVariable > 0)
        {
            fontTimer ++;
            //timerText.fontSize++;
            timerVariable -= Time.deltaTime;
            timerVariable = Mathf.Round(timerVariable * 100) / 100;
            timerText.text = "" + timerVariable;
           
        }
        if(fontTimer > fontInterval)
        {
            timerText.fontSize++;
            
            fontTimer = 0;
            if (timerVariable < 30)
            {
                fontInterval = 30;
            }
            if (timerVariable < 10)
            {
                fontInterval = 3;
            }

        }

        if (timerText.fontSize > textMaxSize)
        {
            timerText.fontSize = textMaxSize; 
        }
      
       
    }
   
}
