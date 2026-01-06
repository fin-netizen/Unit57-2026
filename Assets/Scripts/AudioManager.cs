using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSystem[] sounds;
    public static AudioManager instance;
    public float musicVol;
    public float sfxVol;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            // a reference does not exist, so store it
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            Destroy(gameObject);
        }

    }

    public void Play(string name)
    {
        AudioSystem s = Array.Find(sounds, AudioSystem => AudioSystem.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + ".exe Not found!");
            return;
        }
        s.source.Play();
    }

    public void ChangeAudioSourceVolume(string name, float vol)
    {
        AudioSystem s = Array.Find(sounds, AudioSystem => AudioSystem.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "Not found!");
            return;
        }
        s.source.volume = vol;


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
