using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finished : MonoBehaviour
{
    public void Restart()
    {
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);

        SceneManager.LoadScene("Level " + currentLevel);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
