using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWidth : MonoBehaviour {
    public float width;
    private GameObject WallR;
    private GameObject WallL;
    // Use this for initialization
    void Start () {
        WallR = GameObject.Find("wallright");
        WallL = GameObject.Find("wallleft");

        WallR.transform.position = new Vector3(width / 2, WallR.transform.position.y, WallR.transform.position.z);
        WallL.transform.position = new Vector3(-width / 2, WallL.transform.position.y, WallL.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        

       WallR.transform.position = new Vector3(width/2, WallR.transform.position.y, WallR.transform.position.z);
       WallL.transform.position = new Vector3(-width/2, WallL.transform.position.y, WallL.transform.position.z);
	}
}
