using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public MoveWidth mwidth;
    public widtext widthtext;
    

    void Start()
    {
        mwidth.GetComponent<MoveWidth>().width = GetComponent<Slider>().value / 10;
        widthtext.GetComponent<widtext>().width = GetComponent<Slider>().value / 10;
    }

    public void wallt()
    {
        mwidth.GetComponent<MoveWidth>().width=GetComponent<Slider>().value/10;
        widthtext.GetComponent<widtext>().width = GetComponent<Slider>().value/10;
    }

    internal object Getcomponet<T>()
    {
        throw new NotImplementedException();
    }
}
