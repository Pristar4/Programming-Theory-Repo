using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class MouseAimManager : MonoBehaviour
{
    public Vector3 worldPosition;
    public Camera _camera;
    public GameObject target;

    private void Awake()
    {
    }

    private void Update()
    {
        
        var v3 = Input.mousePosition;
        v3.z = _camera.transform.position.y;
        v3 = _camera.ScreenToWorldPoint(v3);
        if (target)
        {
            Cursor.visible = false;
            target.transform.position = v3;

        }
       
        
        
    }

   
}
