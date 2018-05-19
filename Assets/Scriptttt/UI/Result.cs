using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {
    public int count = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "衝突(壁):" + count.ToString() + "回";
        
	}
}