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
            GameObject.Find("Main CameraA").SetActive(false);
            GameObject.Find("HealthbarA").SetActive(false);
        }
        else
        {
            GameObject.Find("Player_Michal").SetActive(false);
            GameObject.Find("Main CameraM").SetActive(false);
            GameObject.Find("HealthbarM").SetActive(false);
        }
    }


}
