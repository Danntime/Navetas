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
    private void Update()
    {
        Debug.Log(isOnCooldown);
    }
  
    // Coroutine de Cooldown (2s)
     public IEnumerator CoolDownInverter()
    {
        //Change l'animation de cooldown
        animator.SetBool("IsOnCooldownAnim", true);

        // On attends le cd
        yield return new WaitForSeconds(2);
        // Puis on remet l'ancien sprite
        animator.SetBool("IsOnCooldownAnim", false);
        isOnCooldown = false;
    }
}
