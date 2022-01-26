using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfTheEnvironment : MonoBehaviour
{
    private GameObject[] weakVegetation;
    private GameObject[] strongVegetation;
    private GameObject[] dryVegetation;
    private GameObject[] moreDryVegetation;
    private GameObject whiteSquare;

    private int destruction;

    //public Soundtrack soundtrack;
    private void Start()
    {
        destruction = 0;
        PlayerPrefs.SetInt("DestructionOfTheEnvironmentOnThisLevel", 0);
        //PlayerPrefs.SetInt("DestructionOfTheEnvironment", 6);
        destruction = PlayerPrefs.GetInt("DestructionOfTheEnvironment");


        strongVegetation = GameObject.FindGameObjectsWithTag("StrongVegetation");
        dryVegetation = GameObject.FindGameObjectsWithTag("DryVegetation");
        moreDryVegetation = GameObject.FindGameObjectsWithTag("MoreDryVegetation");
        weakVegetation = GameObject.FindGameObjectsWithTag("WeakVegetation");
        whiteSquare = GameObject.Find("WhiteSquare");

        

        Debug.Log(PlayerPrefs.GetInt("DestructionOfTheEnvironment"));
        Debug.Log(destruction);

        if (destruction < 5)
        {

            foreach (GameObject x in dryVegetation)
            {
                x.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);

            }

            foreach (GameObject x in moreDryVegetation)
            {
                x.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);
            }
        }
        else if (destruction >= 5 && destruction < 15)
        {
            whiteSquare.GetComponent<SpriteRenderer>().color = new Color32(236, 183, 0, 70);
            foreach (GameObject x in moreDryVegetation)
            {
                x.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);

            }

            foreach (GameObject x in weakVegetation)
            {
                x.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);

            }

        }
        else if (destruction >= 15)
        {
            whiteSquare.GetComponent<SpriteRenderer>().color = new Color32(236, 183, 0, 110);
            foreach (GameObject x in weakVegetation)
            {
                x.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);

            }

            foreach (GameObject x in strongVegetation)
            {
                x.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);

            }
        }
    }
    private void Update()
    {
        //PlayerPrefs.SetInt("DestructionOfTheEnvironment", 2);
        
        Debug.Log(destruction);


    }

}
