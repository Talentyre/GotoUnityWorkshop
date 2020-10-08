using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenPlatform : MonoBehaviour
{
    [SerializeField]
    private GameObject _platformVisual;
    [SerializeField]
    private GameObject _brokenPartLeft;
    [SerializeField]
    private GameObject _brokenPartRight;

    private Animator _animator;
    private EdgeCollider2D _edgeCollider;

    private void Start()
    {
        _edgeCollider = GetComponent<EdgeCollider2D>();
        _animator = GetComponent<Animator>();
        GetComponent<PlatformController>().OnDoodleHit += OnHit;
    }

    public void OnAnimationEnd()
    {
        _platformVisual.SetActive(false);
        
        _brokenPartLeft.SetActive(true);
        _brokenPartRight.SetActive(true);
    }

    public void OnHit()
    {
        _animator.enabled = true;
        _edgeCollider.enabled = false;
    }
}
