using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ET_StrBox : MonoBehaviour {
    
    private Animation anim;
    private bool Open;

    void Start()
    {
        anim = GetComponent<Animation>();
    }


    void OnCollisionStay(Collision other)
    {
        if (Singleton.Instance.Stage1Key && !Open && other.collider.CompareTag("Hand"))
        {
            Debug.Log("StrBox Open");
            if (Singleton.Instance.Trigger == true || Input.GetMouseButton(0))
            {
                anim.Play();
                Open = true;
            }
        }
    }
}
