using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputButtonStay : MonoBehaviour
{
    private void OnCollisionStay(Collision coll)
    {
        if(coll.collider.CompareTag("Hand"))
            GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionExit(Collision coll)
    {
        if (coll.collider.CompareTag("Hand"))
            GetComponent<Renderer>().material.color = Color.gray;
    }
}
