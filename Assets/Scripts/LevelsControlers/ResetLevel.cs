using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("Level", 0);
    }
}
