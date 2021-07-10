using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SimpleTopdownController : MonoBehaviour
{
   public float speed = 10f;

   public Rigidbody rb;
   private Vector3 movement;

   private void Update()
   {
      
      // INPUT
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.z = Input.GetAxisRaw("Vertical");
      
   }

   private void FixedUpdate()
   {
      //rb.velocity( rb.position + movement * speed * Time.deltaTime);
      
      // TOP DOWN MOVMENT
      rb.velocity = movement.normalized * (speed * Time.deltaTime);
   }
}
