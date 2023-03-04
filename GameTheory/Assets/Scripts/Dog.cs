using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : AnimalController
{
   float jumpForceDog = 500;


   public override void Jump() {
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * jumpForceDog);
        }

    }
}
