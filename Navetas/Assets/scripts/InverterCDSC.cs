using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverterCDSC : MonoBehaviour
{
    public Animator animator;
    [HideInInspector]
    public bool isOnCooldown = false;
    void Start()
    {
    }

    // Crée un cooldown
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && (isOnCooldown == false))
        {
            StartCoroutine(CoolDownInverter());
        }
    }
    IEnumerator CoolDownInverter()
    {
        //Change l'animation de cooldown
        animator.SetBool("IsOnCooldownAnim", true);
        isOnCooldown = true;

        // On attends le cd
        yield return new WaitForSeconds(2);

        // Puis on remet l'ancien sprite
        animator.SetBool("IsOnCooldownAnim", false);
        isOnCooldown = false;
        Debug.Log("caca");

    }
}
