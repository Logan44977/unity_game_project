using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findPower : MonoBehaviour {

    RaycastHit hit;
    string strTag = "electricity";

    public Text txtPrompt;

    public Camera cam;
    
    // Use this for initialization
	void Start ()
    {
        txtPrompt.enabled = false;	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

     
        if (Physics.Raycast(ray, out hit, 15f))
        {
            if(hit.transform.tag == strTag)
            {
                Debug.Log("Found a power source");
                txtPrompt.enabled = true;
            }
            else
            {
                txtPrompt.enabled = false;
            }
        }

       
	}
}
