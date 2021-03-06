﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_Move : MonoBehaviour
{
    private float _vertInput;
    private float _rotationInput;
    private Vector3 _userRot;
    private bool _jumpInput;

    private const float _speedFactor = 0.3f;

    private Rigidbody _rigidbody;
    private Transform _transform;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _vertInput = Input.GetAxis("Vertical");
        _rotationInput = Input.GetAxis("Horizontal");
        _jumpInput = Input.GetButton("Jump");

    }

    private void FixedUpdate()
    {
        _userRot = _transform.rotation.eulerAngles;
        _userRot += new Vector3(0, _rotationInput, 0);

        _transform.rotation= Quaternion.Euler(_userRot);
        _rigidbody.velocity += _transform.forward * _vertInput * _speedFactor;
        if (_jumpInput)
        {
            _rigidbody.AddForce(Vector3.up,ForceMode.VelocityChange);
            _jumpInput = false;
        }
    }
}
