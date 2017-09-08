using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour {
    public Result result;
	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Collider>().gameObject.tag == "Player")
        {
            result.GetComponent<Result>().count++;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
       
            result.GetComponent<Result>().count++;
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
