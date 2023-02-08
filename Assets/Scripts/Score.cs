using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] public int _scoreValue = 0;
    public Text scoreText;
    public static event OnEvenScore BombSpawn;


    public static event OnEvenScore MeteorSpawn;

    public delegate void OnEvenScore();

    private void OnEnable()
    {
        Player.OnTargetTouched += UpScore;
    }
    
    

    private void OnDisable()
    {
        {
            Player.OnTargetTouched -= UpScore;
        }
    }

    private void Start()
    {
        UpScore();
    }

    public void UpScore()
    {
        _scoreValue ++;
        scoreText.text = "Score : " + _scoreValue;
        if (_scoreValue >= 10)
        {
            BombSpawn?.Invoke();
        }

        if (_scoreValue >= 20)
        {
            MeteorSpawn?.Invoke();
        }
    }

    
}
