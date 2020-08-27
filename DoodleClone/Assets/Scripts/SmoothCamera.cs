using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    private Vector3 velocity;

    [SerializeField]
    private float _smoothTime = 0.3f;

    private void Update()
    {
        // si la position Y de la target est supérieure à celle de la caméra
        if (_target.position.y > transform.position.y)
        {
            var targetPos = new Vector3(0, _target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, _smoothTime);
        }
    }
}
