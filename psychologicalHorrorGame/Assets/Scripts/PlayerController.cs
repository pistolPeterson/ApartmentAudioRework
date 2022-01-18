using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Interactable;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed; //player speed
    public int wwiseFootNumber;
    public CharacterController characterContoller;
    public Camera playerCamera;
    Vector3 movement;

    //Wwise 
    private bool footstepIsPlaying = false;
    private float lastFootstepTime = 0;

    [Header("Wwise Events")]
    public AK.Wwise.Event myFootstep;

    [Header("Functional Options")]
    [SerializeField] private bool canInteract = true;

    [Header("Controls")]
    [SerializeField] private KeyCode interactKey = KeyCode.Mouse0;


    [Header("Interaction")]
    [SerializeField] private Vector3 interactionRayPoint = default;
    [SerializeField] private float interactionDistance = default;
    [SerializeField] private LayerMask interactionLayer = default;
    private Interactable currentInteractable;

    // Start is called before the first frame update
    void Start()
    {

        lastFootstepTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        //Debug.DrawRay(transform.position, forward, Color.green);
        //unity movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move horizontal and vertical
         movement = transform.right * horizontalInput + transform.forward * verticalInput;

        //mouse movement
        characterContoller.Move(movement * speed * Time.deltaTime);

        if (canInteract)
        {
            HandleInteractionCheck();
            HandleInteractionInput();
        }
        move();
    }
    private void HandleInteractionCheck()
    {
        if(Physics.Raycast(playerCamera.ViewportPointToRay(interactionRayPoint), out RaycastHit hit, interactionDistance ))
        {
            //Debug.DrawRay(playerCamera.ViewportPointToRay(interactionRayPoint), interactionDistance, Color.green);
            if (hit.collider.gameObject.layer == 6 && (currentInteractable == null || hit.collider.gameObject.GetInstanceID() != currentInteractable.GetInstanceID()))
            {
                hit.collider.TryGetComponent(out currentInteractable);

                if (currentInteractable)
                    currentInteractable.OnFocus();

            }
        } 
        else if (currentInteractable)
        {
            currentInteractable.OnLoseFocus();
            currentInteractable = null;
        }
    }

    private void HandleInteractionInput()
    {
        if(Input.GetKeyDown(interactKey) && currentInteractable != null && Physics.Raycast(playerCamera.ViewportPointToRay(interactionRayPoint), out RaycastHit hit, interactionDistance, interactionLayer))
        {
            currentInteractable.OnInteract();
        }
    }

    void move() //simple move check function to use the AK wwise script 
    {
        if(movement != Vector3.zero)
        {
            if (!footstepIsPlaying)
            {
                Debug.Log("Footstep placed");
                myFootstep.Post(gameObject);
                lastFootstepTime = Time.time;
                footstepIsPlaying = true;
            }
            else
            {
                if (speed > 1)
                {
                    if (Time.time - lastFootstepTime > wwiseFootNumber / speed * Time.deltaTime)
                    {
                        footstepIsPlaying = false;
                    }
                }
            }
        }
    }


}
