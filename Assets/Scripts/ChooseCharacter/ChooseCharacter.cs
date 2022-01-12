using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("Choice", 1);
    }
    public void ChooseAndrzej()
    {
        PlayerPrefs.SetInt("Choice", 1);
    }
    public void ChooseMichal()
    {
        PlayerPrefs.SetInt("Choice", 2);
    }
}
