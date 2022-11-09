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

    // Update is called once per frame
    void Update()
    {
        float playerVelocity = 30.0f;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(direction * playerVelocity * Time.deltaTime);

        if(Input.GetKey(KeyCode.W))
        {
            print("Estou andando");
            animator.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("Parei de andar");
            animator.SetBool("isMoving", false);
        }
    }
}
