using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level";
    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
        FindAnyObjectByType<AudioManager>().Play("Jumpscare");
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);

    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
