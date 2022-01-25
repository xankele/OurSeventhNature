using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfTheEnvironment : MonoBehaviour
{
    GameObject[] weakVegetation;
    GameObject[] strongVegetation;
    GameObject[] dryVegetation;

    void Start()
    {
        //PlayerPrefs.SetInt("DestructionOfTheEnvironment", 2);
        PlayerPrefs.SetInt("DestructionOfTheEnvironmentOnThisLevel", 0);


        if(PlayerPrefs.GetInt("DestructionOfTheEnvironment") == 0)
        {
            dryVegetation = GameObject.FindGameObjectsWithTag("DryVegetation");
            foreach (GameObject x in dryVegetation)
            {
                x.SetActive(false);

            }
        }
        else if(PlayerPrefs.GetInt("DestructionOfTheEnvironment") == 1)
        {
            weakVegetation = GameObject.FindGameObjectsWithTag("WeakVegetation");
            foreach (GameObject x in weakVegetation)
            {
                x.SetActive(false);

            }
        }
        else
        {
            weakVegetation = GameObject.FindGameObjectsWithTag("WeakVegetation");
            foreach (GameObject x in weakVegetation)
            {
                x.SetActive(false);

            }

            strongVegetation = GameObject.FindGameObjectsWithTag("StrongVegetation");
            foreach (GameObject x in strongVegetation)
            {
                x.SetActive(false);

            }
        }
    }

}
