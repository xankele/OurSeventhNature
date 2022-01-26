using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private float healthValue;

    public AudioSource audio;
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (GameObject.Find("Player_Andrzej") == true)
            {
                StartCoroutine(HeartNone());
                audio.clip = audioClip;
                audio.Play();
                collision.GetComponent<HealthA>().AddHealth(healthValue);


            }
            else
            {
                StartCoroutine(HeartNone());
                audio.clip = audioClip;
                audio.Play();
                collision.GetComponent<HealthM>().AddHealth(healthValue);
            }
        }
    }
    IEnumerator HeartNone()
    {
        yield return new WaitForSeconds(0.688f);
        gameObject.SetActive(false);

    }
}
