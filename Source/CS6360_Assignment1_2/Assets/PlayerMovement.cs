using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 movementVector;
    private CharacterController characterController;
    private int speed = 16;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxis("LeftJoystickX") * -speed;
        movementVector.z = Input.GetAxis("LeftJoystickY") * speed;

        movementVector.y = 0;
        characterController.Move(movementVector * Time.deltaTime);

    }
}
