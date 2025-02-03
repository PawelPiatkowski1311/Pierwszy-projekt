using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip[] soundtracks;
    AudioSource AS;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (AS.isPlaying == false)
        {
            AS.clip = soundtracks[Random.Range(0, soundtracks.Length)];
            AS.Play();
        }
    }
}