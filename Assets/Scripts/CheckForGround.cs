using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
    public class CheckForGround : MonoBehaviour
    {
        public bool isSphere;
        bool started;
        public LayerMask mask;
        public float sphereSize;
        public float cubeSizeModifier;

        void Start()
        {
            //Use this to ensure that the Gizmos are being drawn when in Play Mode.
            started = true;

        }
        public bool IsPlayerGrounded()
        {
            //Use the OverlapBox to detect if there are any other colliders within this box area.
            //Use the GameObject's centre, half the size (as a radius) and rotation. This creates an invisible box around your GameObject.
            Collider[] hitColliders;

            if (isSphere)
            {
                hitColliders = Physics.OverlapSphere(gameObject.transform.position, sphereSize, mask);
            }
            else
            {
                hitColliders = Physics.OverlapBox(gameObject.transform.position, (transform.localScale / 2) * cubeSizeModifier, transform.rotation, mask);
            }

            if (hitColliders.Length > 0)
                return true;

            return false;
        }

        public void SwapShape()
        {
            isSphere = !isSphere;
        }


        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;

            if (started)
            {
                if (isSphere)
                    Gizmos.DrawWireSphere(transform.position, sphereSize);
                else
                    Gizmos.DrawWireCube(transform.position, transform.localScale * cubeSizeModifier);
            }

        }

    }
}