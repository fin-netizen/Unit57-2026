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
        AudioManager.instance.pain = value;
        float localValue = value * maxSliderAmount;
        sliderText.text = localValue.ToString("0");
        PlayerPrefs.SetFloat("MusicVolume", AudioManager.instance.pain);
        mixer.SetFloat("MusicVol", Mathf.Log10(AudioManager.instance.pain) * 20);
    }
    public void sfxSliderChange(float value)
    {
        AudioManager.instance.Agony = value;
        float localValue = value * maxSliderAmount;
        sliderText.text = localValue.ToString("0");
        PlayerPrefs.SetFloat("sfxVolume", AudioManager.instance.Agony);
        mixer.SetFloat("sfxVol", Mathf.Log10(AudioManager.instance.Agony) * 20);
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
