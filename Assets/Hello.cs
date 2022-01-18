using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hello : MonoBehaviour
{
    public Image hej;
    void Start()
    {
        //hej[0] = GetComponent<GameObject>();
        //hej.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
        StartCoroutine(NoSiema());
    }

    IEnumerator NoSiema()
    {
        
        hej.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        yield return new WaitForSeconds(0.1f);
        hej.GetComponent<Image>().color = new Color32(255, 255, 225, 10);
        yield return new WaitForSeconds(0.1f);
        hej.GetComponent<Image>().color = new Color32(255, 255, 225, 20);
        yield return new WaitForSeconds(0.1f);
        hej.GetComponent<Image>().color = new Color32(255, 255, 225, 30);
        yield return new WaitForSeconds(0.1f);
        hej.GetComponent<Image>().color = new Color32(255, 255, 225, 40);
        yield return new WaitForSeconds(0.1f);
        hej.GetComponent<Image>().color = new Color32(255, 255, 225, 50);
    }
}
