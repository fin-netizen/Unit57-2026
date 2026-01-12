using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSystem[] sounds;
    public static AudioManager instance;
    public float musicVol;
    public float sfxVol;
    public float musicSliderVol = 0;
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
        if (PlayerPrefs.HasKey("musicVol") == true)
        {
            musicSliderVol = PlayerPrefs.GetFloat("musicVol");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float musicVol, sfxVol;

        musicVol = 0.5f;
        sfxVol = 0.5f;
        mixer.SetFloat("MusicVol", Mathf.Log10(musicVol) * 20 );
        mixer.SetFloat("sfxVol", Mathf.Log10(sfxVol) * 20);
    }
}
