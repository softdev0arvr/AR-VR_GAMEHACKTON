using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordEvent : MonoBehaviour {

    public Text Password;
    
    // Update is called once per frame
	void Update () {
        switch (Singleton.Instance.PasswordCount)
        {
            case 0: Password.text = Singleton.Instance.Password;
                break;
            case 1: 
                Password.text = Singleton.Instance.Password + "___";
                break;
            case 2: Password.text = Singleton.Instance.Password + "__";
                break;
            case 3: Password.text = Singleton.Instance.Password + "_";
                break;
            case 4: Password.text = Singleton.Instance.Password;
                PasswordEnd();
                break;
        }
	}

    void PasswordEnd()
    {
        switch (Singleton.Instance.PasswordMode)
        {
            case 0:
                if (Singleton.Instance.Password.Equals("8722"))
                {
                    Singleton.Instance.Password = null;
                    Singleton.Instance.PasswordCount = 0;
                    Singleton.Instance.PasswordMode++;
                    Application.LoadLevel(2);
                }
                else
                {
                    Singleton.Instance.Password = null;
                    Singleton.Instance.PasswordCount = 0;
                    Singleton.Instance.PasswordModeCtrl = false;
                    Application.LoadLevel(0);
                }
                break;
            case 1:
                break;
   
        }
    }
}
