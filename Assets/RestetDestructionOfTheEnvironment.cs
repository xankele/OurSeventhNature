using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestetDestructionOfTheEnvironment : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("DestructionOfTheEnvironment", 0);
        PlayerPrefs.SetInt("DestructionOfTheEnvironmentOnThisLevel", 0);
    }
}
