﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FokusOnBoss : MonoBehaviour
{
    private bool onCollider = false;
    public bool changeCamera = false;




    private void  OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (GameObject.Find("Player_Andrzej") == true)
            {
                Debug.Log("1");
                if (onCollider == false)
                {
                    this.gameObject.GetComponent<Collider2D>().enabled = false;
                    collision.GetComponent<PlayerMovmentA>().enabled = false;
                    StartCoroutine(Hej());
                }
                else
                {
                    collision.GetComponent<PlayerMovmentM>().enabled = true;
                }

            }
            else
            {
                if (onCollider == false)
                {
                    this.gameObject.GetComponent<Collider2D>().enabled = false;
                    collision.GetComponent<PlayerMovmentM>().enabled = false;
                    StartCoroutine(Hej());
                }
                else
                {
                    collision.GetComponent<PlayerMovmentM>().enabled = true;

                }
            }
        }
    }

    IEnumerator Hej()
    {
        onCollider = true;
        changeCamera = true;
        yield return new WaitForSeconds(5.8f);
        this.gameObject.GetComponent<Collider2D>().enabled = true;
        changeCamera = false;

    }
}