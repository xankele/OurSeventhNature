using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoss : MonoBehaviour
{
    private SpriteRenderer spriteRend;
    private int life;


    private void Awake()
    {
        spriteRend = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("Choice") == 1)
        {
            life = 10;
        }
        if (PlayerPrefs.GetInt("Choice") == 2)
        {
            life = 20;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hit")
        {
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
    private IEnumerator GetDamage()
    {
        spriteRend.color = new Color(1, 0, 0, 0.5f);
        yield return new WaitForSeconds(0.2f);
        spriteRend.color = Color.white;
    }
    private IEnumerator DyingPlant()
    {
        yield return new WaitForSeconds(0.2f);
        this.gameObject.SetActive(false);
    }
}
