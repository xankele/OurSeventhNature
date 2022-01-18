using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowIntro : MonoBehaviour
{
    public Text text;
    public Image img;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(HideText());
        }
    }
    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for(int i = 0; i <= 255; i += 2)
        {
            text.GetComponent<Text>().color = new Color32(255, 255, 225, (byte)i);
            img.GetComponent<Image>().color = new Color32(255, 255, 225, (byte)i);

            yield return new WaitForSeconds(0.04f);
        }
    }
    public void HideThisText()
    {
        StartCoroutine(HideText());
    }
    IEnumerator HideText()
    {
        for (int i = 255; i >= 0; i -= 5)
        {
            text.GetComponent<Text>().color = new Color32(255, 255, 225, (byte)i);
            img.GetComponent<Image>().color = new Color32(255, 255, 225, (byte)i);
            yield return new WaitForSeconds(0.04f);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
