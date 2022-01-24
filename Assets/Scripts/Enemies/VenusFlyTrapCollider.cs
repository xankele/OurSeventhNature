using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusFlyTrapCollider : MonoBehaviour
{
    public VenusFlyTrap vft;
    private bool active;

    private void Start()
    {
        //this.gameObject.GetComponent<Collider2D>().enabled = false;
    }
    private void Update()
    {
        //
        active = vft.active;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (active)
            {
                this.gameObject.GetComponent<Collider2D>().enabled = true;
                //StartCoroutine(DoIt());
                if (GameObject.Find("Player_Andrzej") == true)
                {
                    collision.GetComponent<HealthA>().TakeDamage(1);
                }
                else
                {
                    collision.GetComponent<HealthM>().TakeDamage(1);
                }
            }
        }
        else
            this.gameObject.GetComponent<Collider2D>().enabled = false;


    }

    IEnumerator DoIt()
    {
        this.gameObject.GetComponent<Collider2D>().enabled = true;

        yield return new WaitForSeconds(1);
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(1);
        this.gameObject.GetComponent<Collider2D>().enabled = true;


    }
}
