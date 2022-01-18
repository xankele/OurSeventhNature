using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private int level;
    void Start()
    {
        level = PlayerPrefs.GetInt("Level");
    }
    public void TryAgain()
    {
        if(level == 1)
        {
            SceneManager.LoadScene("Level1");
        }
        else if (level == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
//nazwy sceny