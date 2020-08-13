using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField]
    private float JumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Doodle") &&
            collision.relativeVelocity.y < 0)
        {
            var doodle = collision.gameObject.GetComponent<Doodle>();
            doodle.Jump(JumpForce);
        }
    }
}
