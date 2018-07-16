using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour {

   
    public Text EventText;
    public Text TimeText;

    public AudioClip StartVoiceEvent;
    public AudioClip HeartBeatSound;

    AudioSource bgm;

    private float Min = 4;
    private float Sec = 60;

    void Awake()
    {
        bgm = GetComponent<AudioSource>();
        if (Singleton.Instance.PasswordMode == 0)
        {
            bgm.PlayOneShot(StartVoiceEvent);
        }
    }

	// Update is called once per frame
	void Update () {
        if (Singleton.Instance.EmptyEvent)
        {
            StartCoroutine(EmptyEvent());
        }

        Sec -= Time.deltaTime;
        //초가 0보다 작거나 같으면
        if (Sec <= 0)
        {
            //분을 줄이고
            Min -= 1;
            //분이 0미만이면
            if (Min < 0)
            {
                //게임 오버
            }
            //초를 60으로 한다
            Sec = 60;

            if (Min <= 0 && Sec <= 30)
            {
                bgm.clip = HeartBeatSound;
                bgm.Play();
            }
        }
        TimeText.text = (int)Min + ":" + (int)Sec;
	}

    IEnumerator EmptyEvent()
    {
        EventText.gameObject.SetActive(true);
        EventText.text = "이곳에는 아무것도 없었다.";
        yield return new WaitForSeconds(2.0f);
        Singleton.Instance.EmptyEvent = false;
        EventText.gameObject.SetActive(false);
    }
}
