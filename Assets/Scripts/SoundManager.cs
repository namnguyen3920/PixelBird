using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public static SoundManager Instance { get { return instance; } }
    AudioSource src;

    Collider2D soundTrigger;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        src = GetComponent<AudioSource>();
    }
    public void PlaySound(AudioClip audio)
    {
        src.PlayOneShot(audio);
    }

    
}
