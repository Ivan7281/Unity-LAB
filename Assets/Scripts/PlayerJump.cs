using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    [SerializeField] private float L = 1f; 
    [SerializeField] private float H = 1f;
    [SerializeField] private float T = 1f;
    [SerializeField] bool isJumping = false;
    private JumpCheck jumpCheck;

    private float CalculateY(float x)
        {
            return -4 * H / (L * L) * (x - L) * x;
        }

        private float x = 0f;
        private float y = 0f;
        private float t = 0f;
        private Vector3 startPos;
        private void Reset()
        {
            x = 0f;
            y = 0f;
            t = 0f;
        }

        private void CalculateNextPos(float t)
        {
            x = L * t / T;
            y = CalculateY(x);
        }

    private void Start()
    {
        jumpCheck = GetComponent<JumpCheck>();
    }

    void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space) && jumpCheck.CanJump() && !isJumping)
            {
                isJumping = true;
                startPos = transform.position;
                Reset();
            }
            if (isJumping)
            {
                t += Time.deltaTime;
                CalculateNextPos(t);
                transform.position = startPos + (transform.forward * x) + (transform.up * y );
                if (t > T)
                {
                    isJumping = false;
                }
            }
        }
}
