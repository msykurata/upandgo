using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPos : MonoBehaviour {


    
    public static float Lposx; //位置情報把握のため

    // Use this for initialization

    private GameObject body;

    void Start () {
        
        
        body = GameObject.Find("Camera (eye)");
        float posy = body.transform.position.y / 2;
        transform.position = new Vector3(body.transform.position.x, posy + 0.1f, body.transform.position.z);
        transform.rotation = Quaternion.Euler(0, body.transform.localEulerAngles.y + 90, 0);


    }

    // Update is called once per frame
    void Update () {

        float posy = body.transform.position.y / 2;
		transform.position = new Vector3(body.transform.position.x, posy+0.1f, body.transform.position.z);
        transform.rotation = Quaternion.Euler(0, body.transform.localEulerAngles.y+90, 0);
    }
}
