using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FokusOnBoss : MonoBehaviour
{
    private bool onCollider = false;
    public bool changeCamera = false;

    public AudioSource audio;
    public AudioClip audioClip;



    private void  OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            if (GameObject.Find("Player_Andrzej") == true)
            {
                if (onCollider == false)
                {
                    this.gameObject.GetComponent<Collider2D>().enabled = false;
                    collision.GetComponent<PlayerMovmentA>().enabled = false;
                    StartCoroutine(Hej());
                }
                else
                {
                    collision.GetComponent<PlayerMovmentA>().enabled = true;
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
        audio.clip = audioClip;
        audio.Play();
        onCollider = true;
        changeCamera = true;
        yield return new WaitForSeconds(2.4f);
        this.gameObject.GetComponent<Collider2D>().enabled = true;


        changeCamera = false;

    }
}
