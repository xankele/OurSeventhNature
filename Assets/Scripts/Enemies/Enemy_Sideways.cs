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

    private int life;

    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
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

    private void Update()
    {
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, x));

        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                x = x + 0.5f;
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);   
            }
            else
                movingLeft = false;
        }
        else
        {
            if (transform.position.x < rightEdge)
            {
                x = x - 0.5f;
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
}
