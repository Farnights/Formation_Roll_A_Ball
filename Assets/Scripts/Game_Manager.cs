using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private GameObject _endMenu;

    private void Start()
    {
        _endMenu.SetActive(false);
    }

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
        _endMenu.SetActive(true);
        
    }
}
