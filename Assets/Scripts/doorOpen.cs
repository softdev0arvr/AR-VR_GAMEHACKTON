using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {

    private Animation anim;
    private bool Open;
	
	void Start ()
    {
        anim = GetComponent<Animation>();
	}
	
	
	void OnCollisionStay(Collision other)
    {
        if (!Open && other.collider.CompareTag("Hand"))
        {
            if (Singleton.Instance.Trigger == true || Input.GetMouseButton(0))
            {
                anim.Play();
                Open = true;
            }
        }
    }
}
