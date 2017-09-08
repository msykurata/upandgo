using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlFB : MonoBehaviour {
    public bool vib;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            // タッチパッドに触れた
            device.TriggerHapticPulse(500);
        }

        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            // トリガーを深く引いている Max 3999
            device.TriggerHapticPulse(1500);
        }
        else if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            // トリガーを浅く引いている
            device.TriggerHapticPulse(100);
        }
        
        if (vib)
        {
            device.TriggerHapticPulse(1500);
        }
    }

   
}
