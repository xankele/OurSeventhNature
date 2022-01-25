using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private int life;

    private void Start()
    {
        if (GameObject.Find("Player_Andrzej") == true)
        {
            life = 1;
        }
        else
        {
            life = 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            if(GameObject.Find("Player_Andrzej") == true)
            {
                collision.GetComponent<HealthA>().TakeDamage(damage);
            }
            else
            {
                collision.GetComponent<HealthM>().TakeDamage(damage);
            }
        if (collision.tag == "Hit")
        {
            if (life > 1)
            {
                life--;
            }
            else
            {
                PlayerPrefs.SetInt("DestructionOfTheEnvironmentOnThisLevel", PlayerPrefs.GetInt("DestructionOfTheEnvironmentOnThisLevel") + 1);
                this.gameObject.SetActive(false);
                
            }
        }
    }
}
