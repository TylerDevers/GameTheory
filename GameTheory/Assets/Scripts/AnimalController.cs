using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{

    protected Rigidbody rb;
    float horizontalInput, forwardInput;
    protected float moveSpeed = 1000f, jumpForce = 500f;
    Vector3 move;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
        Jump();

    }

    void FixedUpdate() {
        Move();
    }

    public virtual void Jump() {
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * jumpForce);
        }

    }

    void GetPlayerInput() {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        move = new Vector3(horizontalInput * moveSpeed, rb.position.y, forwardInput * moveSpeed);
    }

    void Move() {
        rb.AddForce(move * Time.deltaTime);
    }
}
