using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void CameraMovement()
    {
        var lookAtPos = Input.mousePosition;
        lookAtPos.z = transform.position.z - Camera.main.transform.position.z;
        lookAtPos = Camera.main.ScreenToWorldPoint(lookAtPos);
        transform.up = lookAtPos - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float playerVelocity = 10.0f;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(direction * playerVelocity * Time.deltaTime);
    }
}