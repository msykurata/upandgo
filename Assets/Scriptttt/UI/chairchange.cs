using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairchange : MonoBehaviour {
    private static GameObject chair;
    private static GameObject armchair;
    public bool ch;
    // Use this for initialization
    void Start () {
        chair = GameObject.Find("chair");
        armchair = GameObject.Find("armchair");
        chair.GetComponent<Renderer>().enabled = false;
        armchair.GetComponent<Renderer>().enabled = true;
        ch = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
   void OnButtonClick()
    {
        if (ch)
        {
            chair.GetComponent<Renderer>().enabled = true;
            armchair.GetComponent<Renderer>().enabled = false;
            ch = false;
        }else
        {
            chair.GetComponent<Renderer>().enabled = false;
            armchair.GetComponent<Renderer>().enabled = true;
            ch = true;
        }
        
    }
}
