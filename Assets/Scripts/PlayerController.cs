using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;


    public float speed = 10.0f;
    public float jumpForce = 300.0f;

    public bool isOnGround = true;
    public float gravityStrength;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityStrength;
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();


    }

    void MovePlayer()
    {
        // Player Controls

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        // Jump Controls

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }

    private void OnCollisionEnter(Collision collision)

    {
        // Checks if the player is on the ground
        if (collision.gameObject.CompareTag("Ground"))

        {
            isOnGround = true;
        }


    }



}
