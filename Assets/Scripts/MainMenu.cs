using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public Slider musicSlider, sfxSlider;

    private void Start()
    {
        AudioManager.instance.musicVol =  PlayerPrefs.GetFloat("MusicVolume");
        print("musicvol=" + PlayerPrefs.GetFloat("MusicVolume"));

        
        AudioManager.instance.sfxVol = PlayerPrefs.GetFloat("sfxVolume");
        print("sfxvol=" + PlayerPrefs.GetFloat("sfxVolume"));

        musicSlider.value = AudioManager.instance.musicVol;
        sfxSlider.value = AudioManager.instance.sfxVol;
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
