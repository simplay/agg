using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkingSpeed = 0.5f;
    public float runningSpeed = 1f;
    public float forwardForce = 20;

    private bool isRunning = false;
    private bool isMovingForward = false;
    private bool isMovingBackward = false;
    private bool isMovingLeft = false;
    private bool isMovingRight = false;

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

        if (Input.GetKey("w"))
        {
            isMovingForward = true;
        }

        if (Input.GetKey("s"))
        {
            isMovingBackward = true;
        }

        if (Input.GetKey("a"))
        {
            isMovingLeft = true;
        }

        if (Input.GetKey("d"))
        {
            isMovingRight = true;
        }

        if (Input.GetKeyDown("f"))
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
    }
}
