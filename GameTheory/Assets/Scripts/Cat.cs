using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : AnimalController
{
    float jumpForceCat = 200;


   public override void Jump() {
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * jumpForceCat);
        }

    }
}
