using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public Transform cameraTransform;
    public Transform playerTransform = null;
    public float moveSpeed = 10.0f;
    CharacterController characterController = null;
    float yVelocity = 0.0f;

    void Start
        ()
    {
        characterController = GetComponent<CharacterController>();

    }



    void Update ()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //float y = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(x, 0, z);
        moveDirection = cameraTransform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        if (characterController.isGrounded == true) //땅에 붙어있는 경우를 나타냄 
        {
            yVelocity = 0.0f;
            

        }

        characterController.Move(moveDirection * Time.deltaTime);//순서도 매우중요 


    }
}
