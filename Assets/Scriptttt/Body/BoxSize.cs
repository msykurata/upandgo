using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class BoxSize : MonoBehaviour {

    // Use this for initialization

    private GameObject body;
    private Vector3 Size;
    public float BoxSizeX;
    private float BoxSizeY;
    public float BoxSizeZ;
    public GameObject SizeInput;

    void Start () {
		body = GameObject.Find("Camera (eye)");
        
        
        Size = this.transform.localScale; //初期値を基準とする。　オブジェクトは1辺1mに設定しておく
        BoxSizeX = 30f;　//入力初期値
        BoxSizeY = 30f;
        BoxSizeZ = 30f;

        transform.localScale = new Vector3(BoxSizeX * Size.x * 0.01f, body.transform.position.y * Size.y, BoxSizeZ * Size.z * 0.01f);
    }

    // Update is called once per frame

	public void BoxSizeCh () {
        try
        {
            //サイズの入力を受け取る
            BoxSizeX = float.Parse(GameObject.Find("BoxX").GetComponent<InputField>().text);
            //BoxSizeY = float.Parse(GameObject.Find("BoxY").GetComponent<InputField>().text);
            BoxSizeZ = float.Parse(GameObject.Find("BoxZ").GetComponent<InputField>().text);
           
        }
        catch (FormatException e)
        {
            Debug.Log(e.Message);
            Debug.Log(BoxSizeX);
            Debug.Log(BoxSizeZ);
            //BoxSizeX == null ? BoxSizeX = 0 : BoxSizeZ = 0;
        }
    }
    private void Update()
    {
        
        transform.localScale = new Vector3(BoxSizeX *Size.x* 0.01f, body.transform.position.y*Size.y, BoxSizeZ *Size.z*0.01f);
    }
    

}
