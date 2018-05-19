using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class widtext : MonoBehaviour {
    public float width;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Width:" + width.ToString() + "m";
        
	}
}
