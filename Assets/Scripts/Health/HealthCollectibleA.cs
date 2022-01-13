using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectibleA : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<HealthA>().AddHealth(healthValue);
            gameObject.SetActive(false);
        }
    }
}
