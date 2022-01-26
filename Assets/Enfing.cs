using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enfing : MonoBehaviour
{

    private int temp;

    void Start()
    {
        temp = PlayerPrefs.GetInt("DestructionOfTheEnvironmentOdnThisLevel");


        if (temp >= 15)
        {
            BadEnding();
        }
        else
        {
            GoodEnding();
        }
    }

    public void GoodEnding()
    {
        GameObject.Find("BadEnding").SetActive(false);
    }
    public void BadEnding()
    {
        GameObject.Find("GoodEnding").SetActive(false);
    }

}
