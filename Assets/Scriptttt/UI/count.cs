using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour {
    public Result result;
    public ResultP resultP;
    // Use this for initialization
    void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            result.GetComponent<Result>().count++;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pall"))
        {
            resultP.GetComponent<ResultP>().countP++;
        }
            
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
