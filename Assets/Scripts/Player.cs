using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent <Animator>();
    }

    void CameraMovement()
    {
        GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
        float mouseLocalX = Input.GetAxis("Mouse X") * 10.0f;
        float mouseLocalY = Input.GetAxis("Mouse Y") * -0.5f;
        transform.Rotate(0.0f, mouseLocalX, 0.0f);
        Camera.transform.Rotate(mouseLocalY, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float playerVelocity = 5.0f;

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isMoving", true);
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(0.0f, 0.0f, verticalInput);
            transform.Translate(direction * playerVelocity * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isMoving", false);
        }

        
        

        CameraMovement();
    }
}