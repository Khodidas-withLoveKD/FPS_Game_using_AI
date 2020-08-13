using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;    //Our naming convention is different, we will use camelCase 

    private Vector3 moveDirection;
    public float speed = 5f;
    private float gravity = 20f;
    public float jumpForce = 10f;
    private float verticalVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
