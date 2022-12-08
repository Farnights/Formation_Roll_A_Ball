using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public Score score;
    [SerializeField] private float Speed = 30f;
    [SerializeField] private GameObject Obstacle;
    [SerializeField] private GameObject[] Spawnposition;
    [SerializeField] private Spawn_Obstacles spawnWall;
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
            score.UpScore(other.gameObject.GetComponent<Target>().Value);
            Destroy(other.gameObject);
            spawnWall.SpawnObstacles();
        }
        
        
    }
}
