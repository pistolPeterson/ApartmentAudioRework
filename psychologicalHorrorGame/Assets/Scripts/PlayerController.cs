using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; //player speed
    private float horizontalInput;
    private float verticalInput;
    public CharacterController characterContoller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //unity movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move horizontal and vertical
        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;

        //mouse movement
        characterContoller.Move(movement * speed * Time.deltaTime);
    }
}
