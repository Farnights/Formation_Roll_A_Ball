using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 30f;
    [SerializeField] private Score _score;
    private AudioSource _audio;
    [SerializeField] private AudioClip[] _audiolist;

    public static event OnEvenScore OnTargetTouched;

    public delegate void OnEvenScore();

    public static event OnEvenScore EvenScore;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _audio = GetComponent<AudioSource>();

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
            _audio.clip = _audiolist[0];
            _audio.Play();
            
            if (_score._scoreValue%2 == 0)
            {
                EvenScore?.Invoke();
            }
            
            if (other.gameObject.CompareTag("Meteor"))
            {
                _score._scoreValue--;
                Destroy(other.gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            _audio.clip = _audiolist[1];
            _audio.Play();
        }
        
        if (collision.gameObject.CompareTag("Bomb"))
        {
            _score._scoreValue--;
            Destroy(collision.gameObject);
        }
        
    }
    
    
}
