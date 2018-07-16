using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HandCtrl : MonoBehaviour {

    private SteamVR_TrackedObject DeviceNum;

    void Awake()
    {
        DeviceNum = GetComponent<SteamVR_TrackedObject>();
    }

	// Update is called once per frame
	void Update () {
        var Device = SteamVR_Controller.Input((int)DeviceNum.index);

        if (Device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("trigger");
            Singleton.Instance.Trigger = true;
        }
        else
        {
            Singleton.Instance.Trigger = false;
        }

        if (Input.GetKeyDown("t"))
        {
            Singleton.Instance.Password = null;
            Singleton.Instance.PasswordCount = 0;
            Singleton.Instance.PasswordMode = 0;
            Application.LoadLevel(0);
        }
	}

    void OnCollisionEnter(Collision coll)
    {
        if (Singleton.Instance.PasswordModeCtrl)
        {
            switch (coll.collider.name)
            {
                case "1":
                    Singleton.Instance.Password += "1";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "2":
                    Singleton.Instance.Password += "2";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "3":
                    Singleton.Instance.Password += "3";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "4":
                    Singleton.Instance.Password += "4";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "5":
                    Singleton.Instance.Password += "5";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "6":
                    Singleton.Instance.Password += "6";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "7":
                    Singleton.Instance.Password += "7";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "8":
                    Singleton.Instance.Password += "8";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "9":
                    Singleton.Instance.Password += "9";
                    Singleton.Instance.PasswordCount++;
                    break;
                case "Reset":
                    Singleton.Instance.Password = null;
                    Singleton.Instance.PasswordCount = 0;
                    break;
            }
        }
    }
}
