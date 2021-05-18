using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Controller : MonoBehaviour
{

    public float speed = 7.5f;
    public float gravity = 50.0f;
    public Transform playerCameraParent;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 60.0f;
    public static bool StatsOpen = false;
    public Stats stats;
    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    Vector2 rotation = Vector2.zero;
    public GameObject StatsScreen;
    
    
    
    [HideInInspector]
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
        characterController = GetComponent<CharacterController>();
        rotation.y = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
         if (characterController.isGrounded)
        {
            // We are grounded, so recalculate move direction based on axes
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            float curSpeedX = canMove ? speed * Input.GetAxis("Vertical") : 0;
            float curSpeedY = canMove ? speed * Input.GetAxis("Horizontal") : 0;
            moveDirection = (forward * curSpeedX) + (right * curSpeedY);

           
        }
        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        moveDirection.y -= gravity * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (StatsOpen)
            {
                StatsScreen.SetActive(false);
                StatsOpen = false;
                canMove = true;
            } else
            {
                StatsScreen.SetActive(true);
                StatsOpen = true;
                canMove = false;
            }
        }
        

        // Player and Camera rotation
        if (canMove)
        {
            rotation.y += Input.GetAxis("Mouse X") * lookSpeed;
            rotation.x += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotation.x = Mathf.Clamp(rotation.x, -lookXLimit, lookXLimit);
            playerCameraParent.localRotation = Quaternion.Euler(rotation.x, 0, 0);
            transform.eulerAngles = new Vector2(0, rotation.y);
            stats.LoadPlayer();
        }
    
        
    }

    



}
