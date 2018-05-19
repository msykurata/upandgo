using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOption : MonoBehaviour {

    public BoxSize boxsize;
    public GameObject SizeInput;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void clickOption()
    {
        if (SizeInput.activeInHierarchy)
        {
            GameObject.Find("BoxX").GetComponent<InputField>().text = boxsize.BoxSizeX.ToString();  //InputFieldにテキストが設定される
            GameObject.Find("BoxZ").GetComponent<InputField>().text = boxsize.BoxSizeZ.ToString();
        }
           
    }
}
