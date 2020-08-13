using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doodle : MonoBehaviour
{

    public void Jump(float jumpForce)
    {
        var rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.up * jumpForce;
    }
}
