using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistDisp : MonoBehaviour {
    private GameObject Wall;
    private GameObject Pole;
    private GameObject WidthDisp;
    private GameObject PlpsDisp;
	// Use this for initialization
	void Start () {

        Wall = GameObject.Find("wallright");
        WidthDisp = GameObject.Find("Widthdisp");
        Pole = GameObject.Find("Cylinder");
        PlpsDisp = GameObject.Find("plpsdisp");

        WidthDisp.GetComponent<Text>().text = "width:" + Wall.transform.position.x * 2 + "m";
        PlpsDisp.GetComponent<Text>().text = "Pole:" + (Pole.transform.position.z + 1) + "m";

    }
	
	// Update is called once per frame
	void Update () {
        WidthDisp.GetComponent<Text>().text = "width:" + Wall.transform.position.x * 2 + "m";
        PlpsDisp.GetComponent<Text>().text = "Pole:" + (Pole.transform.position.z + 1) + "m";
    }
}
