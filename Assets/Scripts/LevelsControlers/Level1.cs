using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public void Start()
    {
        PlayerPrefs.SetInt("Level", 1);
    }
}
