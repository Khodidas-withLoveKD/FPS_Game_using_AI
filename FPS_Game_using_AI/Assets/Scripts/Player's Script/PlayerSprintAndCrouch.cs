﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerSprintAndCrouch : MonoBehaviour
{
    private PlayerMovement playerMovement;

    public float sprint_Speed = 10f;
    public float move_Speed = 5f;
    public float crouch_Speed = 2f;

    private Transform look_Root;
    private float stand_Height = 1.6f;
    private float crouch_Height = 1f;

    private bool is_Crouching;

    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();

        look_Root = transform.GetChild(0); //Here 0 refers to look_Root
    }

    // Update is called once per frame
    void Update()
    {
        Sprint();
        Crouch();
    }

    void Sprint()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && !is_Crouching)
        {
            playerMovement.speed = sprint_Speed;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift) && !is_Crouching)
        {
            playerMovement.speed = move_Speed;
        }
    }

    void Crouch()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(is_Crouching)
            {
                // if we are crouching - stand up

                look_Root.localPosition = new Vector3(0f, stand_Height, 0f);
                playerMovement.speed = move_Speed;

                is_Crouching = false;
            }
            else
            {
                // if we are not crouching - crouch

                look_Root.localPosition = new Vector3(0f, crouch_Height, 0f);
                playerMovement.speed = crouch_Speed;

                is_Crouching = true;
            }
        } // if we press C
    }
}
