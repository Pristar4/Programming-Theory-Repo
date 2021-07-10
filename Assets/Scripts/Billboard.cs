using System;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class Billboard : MonoBehaviour
    {
        public Transform cam;

        private void LateUpdate()
        {
            transform.LookAt(transform.position + cam.forward);
        }
    }
}