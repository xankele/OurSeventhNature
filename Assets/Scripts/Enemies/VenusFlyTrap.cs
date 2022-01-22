using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusFlyTrap : MonoBehaviour
{
    [SerializeField] private float damage;

    [Header("Firetrap Timers")]
    [SerializeField] private float activationDelay;
    [SerializeField] private float activeTime;
    private Animator anim;
    private SpriteRenderer spriteRend;

    private bool triggered;
    public bool active;

    private int life;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

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
        if(collision.tag == "Player")
        {
            if (!triggered)
                StartCoroutine(ActivateFiretrap());
            if (active)
                if (GameObject.Find("Player_Andrzej") == true)
                {
                    //collision.GetComponent<HealthA>().TakeDamage(damage);
                }
                else
                {
                    //collision.GetComponent<HealthM>().TakeDamage(damage);
                }
        }
        if (collision.tag == "Hit")
        {
            if (life > 1)
            {
                life--;
            }
            else
            {
                this.gameObject.SetActive(false);
            }
        }
    }
    private IEnumerator ActivateFiretrap()
    {
        triggered = true;
        //spriteRend.color = Color.red;

        yield return new WaitForSeconds(activationDelay);
        //spriteRend.color = Color.white;
        active = true;
        anim.SetBool("activated", true);

        yield return new WaitForSeconds(activeTime);
        active = false;
        triggered = false;
        anim.SetBool("activated", false);
    }
}
