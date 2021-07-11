using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : Enemy
{

    public Rigidbody Rb;
    public GameObject target;

    private Vector2 movement;
    private void Start()
    {
        _currenthealth = _maxhealth;
        healthBar.SetMaxHealth(_maxhealth);
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        
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

        if (Input.GetButton("Fire1"))
        {
            
            Shoot();
          
            
        }
    }

    private void FixedUpdate()
    {
        var spetim = Speed * Time.deltaTime;
        Rb.velocity = new Vector3(movement.x *spetim,Rb.velocity.y,movement.y* spetim);
    }

    private void Shoot()
    {
        
    }

    
}