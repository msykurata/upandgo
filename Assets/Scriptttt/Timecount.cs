using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour {
    public float timecount = 0;
    private float starttime;
    private bool sss = false;
	// Use this for initialization
	void Start () {
        starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            starttime = Time.time;
            sss = true;
        }
        if (sss)
        {
            timecount = Time.time - starttime;
            GetComponent<Text>().text = "経過時間:" + timecount.ToString("F3");
        }
        if (Input.GetKeyDown(KeyCode.E))
            sss = false;
        if (!sss)
        {
            GetComponent<Text>().text = "経過時間:" + timecount.ToString("F3");
        }
	}
}
