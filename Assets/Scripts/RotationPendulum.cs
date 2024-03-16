using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPendulum : MonoBehaviour
{
    [SerializeField] private float _rotationMax = 45f;
    [SerializeField] private float _rotationSpeed = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Sin(Time.time * _rotationSpeed) * _rotationMax;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
