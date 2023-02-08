using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] public int _scoreValue = -1;
    public Text scoreText;

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
        _scoreValue = -1;
        UpScore();
    }

    public void UpScore()
    {
        _scoreValue ++;
        scoreText.text = "Score : " + _scoreValue;
    }
    

    
}
