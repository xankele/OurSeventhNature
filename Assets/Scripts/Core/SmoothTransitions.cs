using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmoothTransitions : MonoBehaviour
{
    public Image img;

    void Start()
    {
        StartCoroutine(ShowGame());

    }
    IEnumerator ShowGame()
    {
        for (int i = 255; i >= 0; i -= 10)
        {
            img.GetComponent<Image>().color = new Color32(255, 255, 225, (byte)i);
            yield return new WaitForSeconds(0.04f);
        }
    }
}



