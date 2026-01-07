using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level";
    public void NewGameButton()
    {
        SceneManager.LoadSceneAsync(newGameLevel);
        
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);

    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlaySfx(string sfxName)
    {
        //AudioManager.instance.bjectByType<AudioManager>().Play("Jumpscare");
        AudioManager.instance.Play(sfxName);
    }

}
