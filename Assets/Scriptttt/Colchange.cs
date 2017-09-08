using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colchange : MonoBehaviour {
    public CtrlFB fb;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public Color changecol = new Color(1f, 0.5f, 0.5f, 1f);
    public Color precol;

    

    void OnTriggerEnter(Collider other)
    {
       precol = other.gameObject.GetComponent<Renderer>().material.color;
       other.gameObject.GetComponent<Renderer>().material.color = changecol;
        fb.GetComponent<CtrlFB>().vib = true ;
    }

    void OnTriggerExit(Collider other)
    {
        fb.GetComponent<CtrlFB>() .vib = false;
        other.gameObject.GetComponent<Renderer>().material.color = precol;
    }
}
