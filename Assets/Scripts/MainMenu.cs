using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public Slider musicSlider, sfxSlider;

    private void Start()
    {
        AudioManager.instance.musicSliderVol =  PlayerPrefs.GetFloat("MusicVolume");
        print("musicvol=" + PlayerPrefs.GetFloat("MusicVolume"));

        
        AudioManager.instance.sfxSliderVol = PlayerPrefs.GetFloat("sfxVolume");
        print("sfxvol=" + PlayerPrefs.GetFloat("sfxVolume"));

        musicSlider.value = AudioManager.instance.sfxSliderVol;
        sfxSlider.value = AudioManager.instance.sfxSliderVol;
        //set the audio mixer volumes


    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
