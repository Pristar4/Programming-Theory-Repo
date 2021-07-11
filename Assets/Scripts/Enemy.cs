using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityUtils;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    private GameObject _player;
    public int _maxhealth = 50;
    public int _currenthealth;
    public int Speed = 10;
    public HealthBar healthBar;
    public bool isdead = false;
    [SerializeField] private float distance;

    public Rigidbody rb;


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
  
   


    public virtual void bAttack(int damage)
    {
        // if player is in Range do damage
    }
}