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
        else if (level == 3)
        {
            SceneManager.LoadScene("Level3");
        }
        else if (level == 4)
        {
            SceneManager.LoadScene("Level4");
        }
        else if (level == 5)
        {
            SceneManager.LoadScene("Level5");
        }
        else if (level == 6)
        {
            SceneManager.LoadScene("Level6");
        }
        else
        {
            SceneManager.LoadScene("Level7");
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
//nazwy sceny