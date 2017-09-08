using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trig : MonoBehaviour
{
    public Text wcount;
    private int n = 0;

    // Use this for initialization
    void Start()
    {
        GameObject cube = GameObject.Find("Cube");
        cube.GetComponent<Renderer>().material.color = new Color(1f, 0, 0, 0.5f);
        wcount.text = "0回";
    }
    
    void OnTriggerEnter(Collider collider)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 0.5f);
            n++;
            
        }
    }
    /*void OnTriggerStay(Collider collider)
    {

    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0.5f);
        }
    }*/
    /* private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "Player")
         {
             collision.gameObject.GetComponent<Renderer>().material.color=Color.yellow;
         }
     }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 0, 0, 0.25f);
        }
    }*/
    void Update()
    {
        GameObject cube = GameObject.Find("Cube");
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1f));
        }
        wcount.text = n.ToString() + "回";
        /*try
        {
            cube.transform.Rotate(1f, -1f, -1f);
        }
        catch (System.NullReferenceException e) { }
        */
    }
}