using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{

    void Start()
    {
        if (PlayerPrefs.GetInt("Choice") == 2)
        {
            GameObject.Find("Player_Andrzej").SetActive(false);
        }
        else
        {
            GameObject.Find("Player_Michal").SetActive(false);
        }
    }


}
