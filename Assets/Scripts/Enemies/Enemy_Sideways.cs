using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sideways : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    private float x = 0;

    public int life;

    private SpriteRenderer spriteRend;

    public AudioSource audio;
    public AudioClip audioClip;


    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;

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

    private void Update()
    {
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, x));

        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                x = x + Time.deltaTime + 0.5f;
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);   
            }
            else
                movingLeft = false;
        }
        else
        {
            if (transform.position.x < rightEdge)
            {
                x = x - Time.deltaTime - 0.5f;
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                movingLeft = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (GameObject.Find("Player_Andrzej") == true)
            {
                collision.GetComponent<HealthA>().TakeDamage(damage);
            }
            else
            {
                collision.GetComponent<HealthM>().TakeDamage(damage);
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
