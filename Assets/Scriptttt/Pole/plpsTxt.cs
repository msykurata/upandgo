using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plpsTxt : MonoBehaviour {
    public float plpstxt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Pole:" + (plpstxt+1).ToString() + "m";
        
	}
}
