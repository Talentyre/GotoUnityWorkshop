using System;
using UnityEngine;

public class OffScreenCleaner : MonoBehaviour
{
    private Camera _camera;

    public event Action OnObjectClean;

    private void Start()
    {
        _camera = Camera.main;

    }

    void Update()
    {
        var viewportPosition = _camera.WorldToViewportPoint(transform.position);
        if (viewportPosition.y <= -0.5f)
        {
            Destroy(gameObject);
            OnObjectClean?.Invoke();
        }
    }
}
