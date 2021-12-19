using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform playerBody; //transform camera with player body
    public float mouseSensitivity = 100f;
    private float xRotation = 0f; //move up and down

    // Start is called before the first frame update
    void Start()
    {
        //lock cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //unity movement * mouseSensitivity * time
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //decrease x rotation by mouse Y. Rotation is flipped
        xRotation -= mouseY;

        //clamp rotation (clamps given value)
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //rotate body with camera
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
