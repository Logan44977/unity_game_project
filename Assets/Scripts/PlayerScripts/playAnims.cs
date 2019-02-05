using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnims : MonoBehaviour {

    Animator anim;
    private bool isWalking = false;
   // CharacterController charController;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //charController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        //keydown events

        if (Input.GetKeyDown(KeyCode.W))
        {
            isWalking = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (isWalking)
            {
                anim.SetBool("isRunning", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetBool("isCrouch", true);
        }



        //keyup events

        if (Input.GetKeyUp(KeyCode.W))
        {
            isWalking = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            anim.SetBool("isCrouch", false);
        }



        //this is for the lock key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

       
    }
}
