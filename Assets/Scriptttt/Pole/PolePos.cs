using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolePos : MonoBehaviour {
    public float plps;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject Polepos = GameObject.Find("Cylinder");
        
       Polepos.transform.position = new Vector3(Polepos.transform.position.x, Polepos.transform.position.y, plps);
	}
}
