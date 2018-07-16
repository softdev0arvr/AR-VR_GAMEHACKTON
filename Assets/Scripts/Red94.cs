using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red94 : MonoBehaviour {

    public GameObject red;
    public Transform redTransform;
	
	void Start ()
    {
        redTransform = GetComponent<Transform>();

    }
	
	void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Hand"))
        {
            Destroy(red, 10.0f);
        }
    }
}
