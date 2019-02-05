using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batteryDrain : MonoBehaviour {

    public float batteryLife = 100f;
    public float drainRate = 0.002f;

    public Image powerBar;
    public Canvas lowBat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(batteryLife > 0)
        {
            lowBat.enabled = false;
            batteryLife -= drainRate * Time.deltaTime;
          //  Debug.Log(batteryLife);
        }
        else
        {
            lowBat.enabled = true;
        }


        powerBar.fillAmount = batteryLife / 100f;
       // Debug.Log(powerBar.fillAmount);
	}
}
