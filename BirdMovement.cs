using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    
    public CharacterController2D controller;

    public float flySpeed = 40f;

    bool jumpB = false;


    float horizontalMoveB = 0f;
    // Update is called once per frame
    void Update()
    {

        horizontalMoveB = Input.GetAxisRaw("Horizontal") * flySpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jumpB = true;
        }

    }

    void FixedUpdate()
    {

        controller.Move(horizontalMoveB * Time.fixedDeltaTime, false, jumpB);
        jumpB = false;

    }
}

