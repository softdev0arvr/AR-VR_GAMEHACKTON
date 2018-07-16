using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ET_Empty : MonoBehaviour {
    void OnCollisionStay(Collision other)
    {
        if (!(Singleton.Instance.EmptyEvent) && other.collider.CompareTag("Hand"))
        {
            if (Singleton.Instance.Trigger == true || Input.GetMouseButton(0))
            {
                Singleton.Instance.EmptyEvent = true;
            }
        }
    }
}
