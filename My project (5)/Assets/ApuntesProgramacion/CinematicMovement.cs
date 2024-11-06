using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicMovement : MonoBehaviour
{
    public Rigidbody playerRb;


    public float speed;
    public float jumpForce;
    public bool isGrounded;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        //MovementTransportation();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        MovementTranslation();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void MovementTranslation()
    {
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }

    void MovementTransportation()
    {
        transform.position = new Vector3(3, 2, 5);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            isGrounded = false;
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
