using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float _rotationSpeed = 0.2f;

    public int Value = 1;
    
    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed, Space.World);
    }

   
}