using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useGrav : MonoBehaviour {

    private CharacterController characterContoller;
    public bool useGravity = true;
    public float Gravity = 20f;

    void Awake()
    {
        characterContoller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (!characterContoller.isGrounded && useGravity)
        {
            characterContoller.SimpleMove(gameObject.transform.up * Gravity * Time.deltaTime);
        }
    }
}
