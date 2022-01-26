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

    public AudioSource audio;
    public AudioClip audioClip;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("Choice") == 1)
        {
            life = 1;
        }
        if (PlayerPrefs.GetInt("Choice") == 2)
        {
            life = 6;
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
            audio.clip = audioClip;
            audio.Play();
            StartCoroutine(GetDamage());
            if (life > 1)
            {
                life--;
            }
            else
            {
                StartCoroutine(DyingPlant());
            }
        }
    }
    private IEnumerator ActivateFiretrap()
    {
        triggered = true;

        yield return new WaitForSeconds(activationDelay);
        active = true;
        anim.SetBool("activated", true);

        yield return new WaitForSeconds(activeTime);
        active = false;
        triggered = false;
        anim.SetBool("activated", false);
    }
    private IEnumerator GetDamage()
    {
        spriteRend.color = new Color(1, 0, 0, 0.5f);
        yield return new WaitForSeconds(0.2f);
        spriteRend.color = Color.white;
    }
    private IEnumerator DyingPlant()
    {
        yield return new WaitForSeconds(0.2f);
        PlayerPrefs.SetInt("DestructionOfTheEnvironmentOnThisLevel", PlayerPrefs.GetInt("DestructionOfTheEnvironmentOnThisLevel") + 1);
        this.gameObject.SetActive(false);
    }
}
