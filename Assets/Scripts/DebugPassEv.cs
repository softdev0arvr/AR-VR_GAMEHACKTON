using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPassEv : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
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
            }
        }
    }
}
