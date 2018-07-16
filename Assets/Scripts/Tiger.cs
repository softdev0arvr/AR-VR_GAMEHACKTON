using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class Tiger : MonoBehaviour
{
    
    float interval = 0;//시간 누적 
    Animator ani;
    public AudioSource audio;
    private bool TigerShout;


    void Start ()
    {
        ani = GetComponent<Animator>();
        ani.enabled = false;
        audio = GetComponent<AudioSource>();
    }


    void OnCollisionEnter(Collision other)
    {
        if (!TigerShout && other.collider.CompareTag("Hand"))
        {
            ani.enabled = true;
            audio.Play();
            Destroy(ani, 3.0f);
            TigerShout = true;
        }
    }
}
