using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mainMenu;
    public GameObject restartMenu;
    

    void Start()
    {
        //stop game
        if (SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByName("game")))
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartOpen()
    {
        Time.timeScale = 0f;
        mainMenu.SetActive(false);
        restartMenu.SetActive(true);

    }

    public void gotoMenu()
    {
        SceneManager.LoadScene("game");
    }

    public void Restrat()
    {
        SceneManager.LoadScene("restart");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
