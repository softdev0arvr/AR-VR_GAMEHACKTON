using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ET_Key : MonoBehaviour {
    void OnCollisionStay(Collision other)
    {
        if (other.collider.CompareTag("Hand"))
        {
            if (Singleton.Instance.Trigger == true || Input.GetMouseButton(0))
            {
                Singleton.Instance.Stage1Key = true;
                gameObject.SetActive(false);
            }
        }
    }
}
