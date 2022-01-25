﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    public AudioSource audio;
    [Header("0-menu, 1-kupa")]
    public AudioClip[] audioClips;
    private bool temp;
    private bool temp2;
    private int sound;
    private int soundmenu;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }
    private void Update()
    {
        sound = PlayerPrefs.GetInt("Level");
        soundmenu = PlayerPrefs.GetInt("MenuSound");
        if (soundmenu == 1 && temp2 == false)
        {
            MenuSound();
            temp2 = !temp2;
        }
        if (soundmenu == 0 && temp2 == true)
        {
            temp = !temp;
            temp2 = !temp2;
        }
        if (sound == 0 && temp == false)
        {
            MenuSound();
            temp = !temp;
        }
        if (sound == 1 && temp == true)
        {
            Step_01();
            temp = !temp;
        }
        if (sound == 2 && temp == false)
        {
            Step_02();
            temp = !temp;
        }
    }
    public void Start()
    {
        PlayerPrefs.SetInt("MenuSound", 0);
        temp = false;
        temp2 = false;
        sound = 0;
        soundmenu = 0;
    }
    public void MenuSound()
    {
        audio.Pause();
        audio.clip = audioClips[0];
        audio.Play();
    }
    public void Step_01()
    {
        audio.Pause();
        audio.clip = audioClips[1];
        audio.Play();
    }
    public void Step_02()
    {
        audio.Pause();
        audio.clip = audioClips[2];
        audio.Play();
    }
}
