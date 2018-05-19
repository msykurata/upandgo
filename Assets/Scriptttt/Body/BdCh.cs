using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BdCh : MonoBehaviour {

    private static GameObject Circle;
    private static GameObject Square;
    private bool flg = true;

    // Use this for initialization
    void Start () {
        var img = GetComponent<Image>();
        img.sprite = square;
        Circle = GameObject.Find("Body");
        Square = GameObject.Find("BodyBox");
        flg = true;
        Circle.SetActive(!flg);
        Square.SetActive(flg);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public Sprite circle;
    public Sprite square;
    
    public void BDCH()
    {
        var img = GetComponent<Image>();
        img.sprite = (flg) ? circle : square;
        Circle.SetActive(flg);
        Square.SetActive(!flg);
        flg = !flg;
    }
}
