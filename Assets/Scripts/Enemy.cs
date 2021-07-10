using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Enemy : MonoBehaviour
{
    private GameObject _player;
    public int _maxhealth = 50;
    public int _currenthealth;
    public int Speed = 10;
    public HealthBar healthBar;
    public bool isdead = false;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player");
    }


    public virtual void TakeDamage(int damage)
    {
        if (_currenthealth > 0)
        {
            _currenthealth -= damage;
            healthBar.SetHealth(_currenthealth);
        }
    }




    public virtual void CheckRange()
    {
        
        //Check if player is in Attack Range
    }

    public virtual void Attack(int damage)
    {
        // if player is in Range do damage
        
    }
    
}