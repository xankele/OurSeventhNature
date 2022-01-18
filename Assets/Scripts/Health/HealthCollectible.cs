using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (GameObject.Find("Player_Andrzej") == true)
            {
                collision.GetComponent<HealthA>().AddHealth(healthValue);
                gameObject.SetActive(false);
            }
            else
            {
                collision.GetComponent<HealthM>().AddHealth(healthValue);
                gameObject.SetActive(false);
            }
        }
    }
}
