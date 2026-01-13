using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
public class SliderScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;
    public AudioMixer mixer;
    [SerializeField] private float maxSliderAmount = 100.0f;
    float musicVol, sfxVol;
  
    public void MusicSliderChange(float value)
    {
        AudioManager.instance.musicVol = value;
        float localValue = value * maxSliderAmount;
        sliderText.text = localValue.ToString("0");
        PlayerPrefs.SetFloat("MusicVolume", AudioManager.instance.musicVol);
        mixer.SetFloat("MusicVol", Mathf.Log10(AudioManager.instance.musicVol) * 20);
    }
    public void SfxSliderChange(float value)
    {
        AudioManager.instance.sfxVol = value;
        float localValue = value * maxSliderAmount;
        sliderText.text = localValue.ToString("0");
        PlayerPrefs.SetFloat("sfxVolume", AudioManager.instance.sfxVol);
        mixer.SetFloat("sfxVol", Mathf.Log10(AudioManager.instance.sfxVol) * 20);
    }
    public void PlayMusic(string musicName)
    {
        AudioManager.instance.Play(musicName);
    }
    public void PlaySfx(string sfxName)
    {
        //AudioManager.instance.bjectByType<AudioManager>().Play("Jumpscare");
        AudioManager.instance.Play(sfxName);
        
    }
}
