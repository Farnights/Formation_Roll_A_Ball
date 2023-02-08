using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float Speed = 30f;
    [SerializeField] private Spawn_Obstacles spawnWall;

    public UnityEvent UpdateScore;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        _rigidbody.AddForce(Input.GetAxis("Horizontal")*Speed, 0.0f, Input.GetAxis("Vertical")*Speed);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            UpdateScore?.Invoke();
            Destroy(other.gameObject);
        }
        
        
    }
}
