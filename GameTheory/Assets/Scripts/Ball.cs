using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    

    public void IncreaseGravity(Rigidbody rb) {
        rb.AddForce(Vector3.down * 2);
    }











}
