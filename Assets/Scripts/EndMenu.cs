using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _endMessage;
    
    
    private void OnEnable()
    {
        Player.End += End;
    }

    private void OnDisable()
    {
        Player.End -= End;
    }

    public void End()
    {
        _endMessage.text = "YOU LOSE";
        
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
