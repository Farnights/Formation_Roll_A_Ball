using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _scoreValue = 0;
    public Text scoreText;
    public GameObject winMessage;

    public void UpScore(int value)
    {
        _scoreValue += value;
        scoreText.text = "Score : " + _scoreValue.ToString();
        if (_scoreValue >= 12)
        {
            winMessage.SetActive(true);
        }
    }
    

    
}
