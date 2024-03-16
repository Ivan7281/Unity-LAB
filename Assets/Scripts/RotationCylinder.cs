using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCylinder : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotationDirection, Space.World);
    }
}
