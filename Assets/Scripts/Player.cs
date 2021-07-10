using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : Enemy
{

    

    private void Start()
    {
        _currenthealth = _maxhealth;
        healthBar.SetMaxHealth(_maxhealth);
    }

    private void Update()
    {
        if (_currenthealth > 0)
        {
            isdead = false;
            if (Input.GetKeyDown(KeyCode.G))
            {
                TakeDamage(20);
            }
        }
        else
        {
            isdead = true;
        }
    }

    
}