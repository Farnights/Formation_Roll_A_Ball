using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBall : MonoBehaviour
{
    [SerializeField] private HUDDatas _hud;
    
    private void OnEnable()
    {
        Player.SpeedMid += Mid;
        Player.SpeedLow += Low;
    }

    private void OnDisable()
    {
        Player.SpeedMid -= Mid;
        Player.SpeedLow -= Low;
    }
    
    

    public void Low()
    {
        _hud.SpeedBall = _hud.SpeedBallLowLife;
    }
    
    public void Mid()
    {
        _hud.SpeedBall = _hud.SpeedBallMidLife;
    }
}


