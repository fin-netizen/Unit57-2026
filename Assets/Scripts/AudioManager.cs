using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSystem[] sounds;
    public static AudioManager instance;
    public float musicVol;
    public float sfxVol;
    public AudioMixer mixer;


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
            return;

        }
        foreach (AudioSystem s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.mixer;
        }
    }

   public void Play(string name)
   {
        AudioSystem s = Array.Find(sounds, AudioSystem => AudioSystem.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + ".exe not found");
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
        if (PlayerPrefs.HasKey("MusicVolume") == true)
        {
            AudioManager.instance.musicVol = PlayerPrefs.GetFloat("MusicVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("MusicVolume", 1f);
        }
        if (PlayerPrefs.HasKey("sfxVolume") == true)
        {
            AudioManager.instance.sfxVol = PlayerPrefs.GetFloat("sfxVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("sfxVolume", 1f);
        }
    }


    void Update()
    {
        

        
        
       
       
    }

}
