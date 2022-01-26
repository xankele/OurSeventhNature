using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackM : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform kickPoint;
    [SerializeField] private Transform punchPoint;
    [SerializeField] private GameObject kick;
    [SerializeField] private GameObject punch;

    private Animator anim;
    private PlayerMovmentM playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovmentM>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("k") && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();
        if (Input.GetKeyDown("l") && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack2();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        kick.transform.position = kickPoint.position;
        kick.GetComponent<Kopniak>().SetDirection(Mathf.Sign(transform.localScale.x));
    }    
    private void Attack2()
    {
        anim.SetTrigger("attack2");
        cooldownTimer = 0;

        punch.transform.position = punchPoint.position;
        punch.GetComponent<Pacanie>().SetDirection(Mathf.Sign(transform.localScale.x));
    }

}
