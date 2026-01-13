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

        musicSlider.value = AudioManager.instance.musicSliderVol;

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
