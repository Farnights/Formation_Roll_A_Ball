using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 0.2f;
    [SerializeField] public int Value = 1;

    private void Start()
    {
        gameObject.transform.rotation = Quaternion.Euler(90f,0f,0f);
    }

    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed, Space.World);
    }
    
}