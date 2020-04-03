using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Rigidbody rg;

    public float walkingSpeed = 0.5f;
    public float runningSpeed = 1f;

    private bool isRunning = false;
    private bool isMovingForward = false;
    private bool isMovingBackward = false;
    private bool isMovingLeft = false;
    private bool isMovingRight = false;
    private bool jump = false;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        isRunning = Input.GetKey(KeyCode.LeftShift);
        isMovingForward = false;
        isMovingBackward = false;
        isMovingLeft = false;
        isMovingRight = false;
        jump = false;
        
        if (Input.GetKey(KeyCode.W))
        {
            isMovingForward = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            isMovingBackward = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            isMovingLeft = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            isMovingRight = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            gm.PlaceBlock(transform);
        }
    }

    private void FixedUpdate()
    {
        float speed = isRunning ? runningSpeed : walkingSpeed;

        if (isMovingForward)
        {
            transform.position += transform.TransformDirection(Vector3.forward * speed);
        }

        if (isMovingBackward)
        {
            transform.position += transform.TransformDirection(Vector3.back * speed);
        }

        if (isMovingLeft)
        {
            transform.position += transform.TransformDirection(Vector3.left * speed * 0.75f);
        }

        if (isMovingRight)
        {
            transform.position += transform.TransformDirection(Vector3.right * speed * 0.75f);
        }

        if (jump)
        {
            
        }
    }
}
