using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    public AudioSource audio;
    [Header("0-menu, " +
        "1-intro, " +
        "2-tlo fajnie, " +
        "3-tlo mniej fajnie, " +
        "4-no nie fajnie, " +
        "5-hej boss")]
    public AudioClip[] audioClips;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }
    public void Start()
    {
        audio.clip = audioClips[0];
        audio.Play();
    }
}
