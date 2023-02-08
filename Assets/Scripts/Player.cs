using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 30f;
    [SerializeField] private Score _score;

    public delegate void UpdateScore();
    public static event UpdateScore OnTargetTouched;

    public delegate void OnEvenScore();

    public static event OnEvenScore EvenScore;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        _rigidbody.AddForce(Input.GetAxis("Horizontal")*_speed, 0.0f, Input.GetAxis("Vertical")*_speed);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            OnTargetTouched?.Invoke();
            Destroy(other.gameObject);
            
            if (_score._scoreValue%2 == 0)
            {
                EvenScore?.Invoke();
            }
        }

        
        
        
    }
}
