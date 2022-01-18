using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowIntro : MonoBehaviour
{
    public Text text;
    void Start()
    {
        //hej[0] = GetComponent<GameObject>();
        //hej.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for(int i = 0; i <= 255; i += 2)
        {
            text.GetComponent<Text>().color = new Color32(255, 255, 225, (byte)i);
            yield return new WaitForSeconds(0.04f);
        }
    }
}
