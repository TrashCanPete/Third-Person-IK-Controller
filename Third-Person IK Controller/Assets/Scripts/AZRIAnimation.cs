using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AZRIAnimation : MonoBehaviour
{
    Animator anim;
    public float moveSpeed;
    public float runSpeed;
  

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float move = Input.GetAxis("Horizontal") * moveSpeed;
        float run = Input.GetAxis("Horizontal") * moveSpeed;

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT WALK") && move > 0)
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUN") && run > 0)
        {
            transform.position += Vector3.forward * runSpeed * Time.deltaTime;
        }
        */
        

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FIDGET"))
            {
                anim.SetTrigger("DrawSword");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
            {
                anim.SetTrigger("DrawSword");
            }
        }

        if (Input.GetButtonDown("Fire1") ^ Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUN"))
            {
                anim.SetTrigger("DrawSword");
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("SHEATH"))
            {
                anim.SetTrigger("DrawSword");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT IDLE"))
            {
                anim.SetTrigger("Sheath");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT WALK"))
            {
                anim.SetTrigger("Sheath");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("ATTACK"))
            {
                anim.SetTrigger("Sheath");
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("Attack");
        }
        

        if (Input.GetAxis("Horizontal") >0 || Input.GetAxis("Horizontal") > 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT IDLE"))
            {
                anim.SetBool("CombatWalk", true);
                anim.SetBool("StopCombatWalking", false);
            }
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FIDGET"))
            {
                anim.SetBool("Run", true);
                anim.SetBool("StopRunning", false);
            }
        }

        if (Input.GetAxis("Horizontal") <= 0 || Input.GetAxis("Horizontal") <= 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT WALK"))
            {
                anim.SetBool("CombatWalk", false);
                anim.SetBool("StopCombatWalking", true);
            }
        }
        if (Input.GetAxis("Horizontal") <= 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("ATTACK"))
            {
                anim.SetBool("CombatWalk", false);
                anim.SetBool("StopCombatWalking", true);
            }
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
            {
                anim.SetBool("Run", true);
                anim.SetBool("StopRunning", false);
            }
        }

        if (Input.GetAxis("Horizontal") <= 0 || Input.GetAxis("Horizontal") <= 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUN"))
            {
                anim.SetBool("StopRunning", true);
                anim.SetBool("Run", false);
            }
        }
    }
}
