using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeen : MonoBehaviour {

    public AudioSource alarm;
    public AudioClip alarmSound;

    void Start()
    {
        
    }
    void OnTriggerEnter()
    {
        if (alarm.isPlaying == false)
        {
            alarm.PlayOneShot(alarmSound);
        }
    }
}
