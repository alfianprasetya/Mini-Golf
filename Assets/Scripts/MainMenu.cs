using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);

        SceneManager.LoadScene("Level " + currentLevel);
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
