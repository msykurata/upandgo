using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plpsSlider : MonoBehaviour {

    public PolePos ppos;
    public plpsTxt ptxt;
    

    void Start()
    {
        ppos.GetComponent<PolePos>().plps = GetComponent<Slider>().value / 10;
        ptxt.GetComponent<plpsTxt>().plpstxt = GetComponent<Slider>().value / 10;
    }

    public void plps()
    {
        ppos.GetComponent<PolePos>().plps=GetComponent<Slider>().value/10;
        ptxt.GetComponent<plpsTxt>().plpstxt = GetComponent<Slider>().value/10;
    }

    internal object Getcomponet<T>()
    {
        throw new NotImplementedException();
    }
}
