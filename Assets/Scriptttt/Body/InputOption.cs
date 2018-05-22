using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOption : MonoBehaviour {

    
    public GameObject SizeInput;

    private string inputX;
    private string inputZ;
    private int count = 0;
    // Use this for initialization
    void Start () {
        inputX = "30";
        inputZ = "30";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void clickOption()
    {
        if (SizeInput.activeInHierarchy&&count==0)
        {
            GameObject.Find("BoxX").GetComponent<InputField>().text = inputX;  //InputFieldにテキストが設定される
            GameObject.Find("BoxZ").GetComponent<InputField>().text = inputZ;
        }
        count++;
           
    }
   
}
