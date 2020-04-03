using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float mouseSensivity = 200f;
    private Camera camera;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindObjectOfType<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
