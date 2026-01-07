using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    private int PlayerHealth;
    int Highscore;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            //this code runs only once
            //read player prefs values and store them in AudioManager.instance.musicVol


            print("Init levelmanager");


            print("do not destroy");

        }
        else
        {
            print("do destroy");
            Destroy(gameObject);
            return;
        }


    }

    void Start()
    {
        print("start level manager");
        if (PlayerPrefs.HasKey("musicVol") == true)
        {
            AudioManager.instance.musicVol = PlayerPrefs.GetFloat("musicVol");
        }

        if (PlayerPrefs.HasKey("sfxVol") == true)
        {
            AudioManager.instance.sfxVol = PlayerPrefs.GetFloat("sfxVol");
        }

    }

    public void SetHighScore(int score)
    {
        Highscore = score;
    }
    public int GetHighScore()
    {
        return Highscore;
    }
    //these methods are globally accessible
    public void Setplayerhealth(int health)
    {
        PlayerHealth = health;
    }
    public int GetPlayerHealth()
    {
        return PlayerHealth;
    }
    public void HealthModefier(int amount)
    {
        PlayerHealth += amount;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        
    }
}
