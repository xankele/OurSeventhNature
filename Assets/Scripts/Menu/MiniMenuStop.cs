using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMenuStop : MonoBehaviour
{
    public void StopMovement()
    {
        if (GameObject.Find("Player_Andrzej") == true)
        {

            GetComponent<PlayerMovmentA>().enabled = false;

        }
        else
        {
            GetComponent<PlayerMovmentM>().enabled = false;
        }
    }
    public void StartMovement()
    {
        if (GameObject.Find("Player_Andrzej") == true)
        {

            GetComponent<PlayerMovmentA>().enabled = true;

        }
        else
        {
            GetComponent<PlayerMovmentM>().enabled = true;
        }
    }
}
