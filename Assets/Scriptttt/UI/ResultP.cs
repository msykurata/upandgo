using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultP : MonoBehaviour {
    public int countP = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "衝突(棒):" + countP.ToString() + "回";
        
	}
}