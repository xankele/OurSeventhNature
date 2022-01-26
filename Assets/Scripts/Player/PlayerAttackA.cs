using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackA : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;

    private Animator anim;
    private PlayerMovmentA playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    public AudioSource audio;
    public AudioClip audioClip;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovmentA>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("k") && cooldownTimer > attackCooldown && playerMovement.canAttack())
        {
            Attack();
            audio.clip = audioClip;
            audio.Play();
        }
            

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<ProjectileA>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindFireball()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
