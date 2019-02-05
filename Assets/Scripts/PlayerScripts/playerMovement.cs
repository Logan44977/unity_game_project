using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    Animator anim;
    public Quaternion newRotation;
    public float smooth = 0.05f;
    public Transform cam;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        movement(v, h);
    }

    void movement(float v, float h)
    {
        if (h != 0f || v != 0f)
        {
            rotate(v, h);

            anim.SetFloat("speed", 1);
        }
        else
        {
            anim.SetFloat("speed", 0);
        }
    }

    void rotate(float v, float h)
    {
        if (v > 0)
        {
            if (h > 0)
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 45, 0);
            }

            else if (h < 0)
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 305, 0);
            }

            else
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y, 0);
            }
        }

        else if (v < 0)
        {
            if (h > 0)
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 135, 0);
            }
            else if (h < 0)
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 225, 0);
            }
            else
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 180, 0);
            }
        }

        else
        {
            if (h > 0)
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 90, 0);
            }

            else if (h < 0)
            {
                newRotation = Quaternion.Euler(0, cam.eulerAngles.y + 270, 0);
            }
            else
            {
                newRotation = transform.rotation;
            }
        }

        newRotation.x = 0;
        newRotation.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, smooth);
    }
}
