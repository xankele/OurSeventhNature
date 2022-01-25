using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Image img;

    public void PlayGame()
    {
        StartCoroutine(PlayGameNow());
    }
    public void BackToMenu()
    {
        StartCoroutine(HideGame());
    }
    public void QuiteGame()
    {
        Debug.Log("Quit :(");
        Application.Quit();
    }
    public void SoundMenuOn()
    {
        PlayerPrefs.SetInt("MenuSound", 1);
    }
    public void SoundMenuOff()
    {
        PlayerPrefs.SetInt("MenuSound", 0);
    }
    IEnumerator HideGame()
    {
        for (int i = 0; i <= 255; i += 10)
        {
            img.GetComponent<Image>().color = new Color32(255, 255, 225, (byte)i);
            yield return new WaitForSeconds(0.04f);
        }
        SceneManager.LoadScene("Menu");

    }
    IEnumerator PlayGameNow()
    {
        for (int i = 0; i <= 255; i += 10)
        {
            img.GetComponent<Image>().color = new Color32(255, 255, 225, (byte)i);
            yield return new WaitForSeconds(0.04f);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
