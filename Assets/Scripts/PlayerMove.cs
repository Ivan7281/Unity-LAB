using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 80;
    [SerializeField] private float _moveSpeed = 10;
    [SerializeField] private float _accelerationSpeed = 0.2f;
    [SerializeField] private float _maxAccelerationTime = 0.3f;

    private bool _isAccelerating = false;
    private float _accelerationTimer = 0f;
    private CheckGround isGround;

    private void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(rotation * _rotateSpeed * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        float direction = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.LeftShift) && !_isAccelerating)
        {
            _isAccelerating = true;
            _accelerationTimer = 0f;
        }

        float distance = direction * _moveSpeed * Time.deltaTime;

        if (_isAccelerating && _accelerationTimer < _maxAccelerationTime)
        {
            _accelerationTimer += Time.deltaTime;
            distance += _accelerationSpeed;
        }
        else
        {
            _isAccelerating = false;
        }

        transform.Translate(distance * Vector3.forward);
    }

    private void Start()
    {
        isGround = gameObject.GetComponentInChildren<CheckGround>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        if (isGround.IsOnGround)
        {
            Move();
        }
    }
}
