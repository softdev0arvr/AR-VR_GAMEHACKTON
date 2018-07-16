using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordMode : MonoBehaviour {
    void OnCollisionStay(Collision other)
    {
        if (other.collider.CompareTag("Hand"))
        {
            if (Singleton.Instance.Trigger == true || Input.GetMouseButton(0))
            {
                Singleton.Instance.PasswordModeCtrl = true;
                Application.LoadLevel(1);
            }
        }
    }
}
