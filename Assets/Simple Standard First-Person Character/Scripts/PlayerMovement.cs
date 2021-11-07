using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController characterController;

    [SerializeField]
    private float movementSpeed = 5f;

    [SerializeField]
    private float jumpHeight = 1f;

    private Vector3 inputDirection;
    private Vector3 momentum;

    private float horizontalAxis;
    private float verticalAxis;

    // Update is called once per frame
    private void Update()
    {
        /*Get Inputs*/
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        inputDirection = transform.right * horizontalAxis + transform.forward * verticalAxis; //Calculate the direction based on the inputs

        if (characterController.isGrounded) //Check if grounded
        {
            /*Grounded*/
            if (Input.GetButtonDown("Jump")) //Check for Jump Input
            {
                momentum.y = Mathf.Sqrt(jumpHeight * -2.0f * -9.81f); //Jump
            }
        }
        else
        {
            /*Not grounded*/
            momentum.y += -9.81f * Time.deltaTime; //pull the character down
        }

        characterController.Move(inputDirection * movementSpeed * Time.deltaTime + momentum * Time.deltaTime); //Move the player based on inputDirection and momentum vectors
    }
}
