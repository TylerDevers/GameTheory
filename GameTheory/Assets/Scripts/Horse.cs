using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : AnimalController
{
    float jumpForceHorse = 750;


   public override void Jump() {
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * jumpForceHorse);
        }

    }
}
