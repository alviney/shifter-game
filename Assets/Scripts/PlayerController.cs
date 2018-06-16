using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
    public class PlayerController : MonoBehaviour
    {

        public float jumpForce = 0;
        public float velocityClamp;
        public GameObject cube;
        public GameObject sphere;
        private Rigidbody rb;
        private bool switcher;
        // private bool colorSwitcher = true;
        // private Renderer sphereRend;
        // private Renderer cubeRend;
        private GameObject activeGameObject;

        private CheckForGround checkForGround;
        // Use this for initialization
        void Start()
        {
            checkForGround = this.GetComponent<CheckForGround>();

            rb = this.GetComponent<Rigidbody>();
            switcher = false;

            // sphereRend = sphere.transform.GetComponent<Renderer>();
            // cubeRend = cube.transform.GetComponent<Renderer>();

            // sphereRend.material.SetColor("_Color", Color.blue);
            // cubeRend.material.SetColor("_Color", Color.blue);
        }

        void Update()
        {

        }

        public void Tap()
        {
            print("Tap");
        }
        public void Jump(Vector2 screenDelta)
        {
            if (checkForGround.IsPlayerGrounded())
                this.GetComponent<LeanForceRigidbody>().Apply(screenDelta, jumpForce, velocityClamp);
        }

        public void SwapBodies()
        {
            checkForGround.SwapShape();
            cube.SetActive(!switcher);
            sphere.SetActive(switcher);
            switcher = !switcher;
        }

        // public void SwapColor()
        // {
        //     if (colorSwitcher)
        //     {
        //         sphereRend.material.SetColor("_Color", Color.yellow);
        //         cubeRend.material.SetColor("_Color", Color.yellow);
        //     }
        //     else
        //     {
        //         sphereRend.material.SetColor("_Color", Color.blue);
        //         cubeRend.material.SetColor("_Color", Color.blue);
        //     }

        //     colorSwitcher = !colorSwitcher;

        // }

        public void IncreaseJumpForce()
        {
            jumpForce++;
        }

        public void DecreaseJumpForce()
        {
            jumpForce--;
        }
    }
}
