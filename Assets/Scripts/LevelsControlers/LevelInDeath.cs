using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInDeath : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") - 1);
    }
}
