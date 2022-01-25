using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfTheEnvironment : MonoBehaviour
{
    GameObject[] weakVegetation;
    GameObject[] strongVegetation;
    GameObject[] dryVegetation;
    GameObject[] moreDryVegetation;

    //public Soundtrack soundtrack;

    void Start()
    {
        //PlayerPrefs.SetInt("DestructionOfTheEnvironment", 2);
        PlayerPrefs.SetInt("DestructionOfTheEnvironmentOnThisLevel", 0);


        if(PlayerPrefs.GetInt("DestructionOfTheEnvironment") == 0)
        {
            //soundtrack.GetComponent<Soundtrack>().Step_01();
            //GetComponentInParent<Soundtrack>().Step_01();
            dryVegetation = GameObject.FindGameObjectsWithTag("DryVegetation");
            foreach (GameObject x in dryVegetation)
            {
                x.SetActive(false);

            }
            moreDryVegetation = GameObject.FindGameObjectsWithTag("MoreDryVegetation");
            foreach (GameObject x in moreDryVegetation)
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
            moreDryVegetation = GameObject.FindGameObjectsWithTag("MoreDryVegetation");
            foreach (GameObject x in moreDryVegetation)
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
