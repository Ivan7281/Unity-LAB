using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFly : MonoBehaviour
{
    [SerializeField] private float _flySpeed = 5;
    [SerializeField] private float _rotateSpeed = 40;
    [SerializeField] private float _liftForce = 1;
    [SerializeField] private float _gravityForce = -2;
    // Start is called before the first frame update

    private void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(rotation * _rotateSpeed * Time.deltaTime * Vector3.up);
    }

    private void Fly()
    {
        float direction = Input.GetAxis("Vertical");
        float distance = 0;
        distance += direction * _flySpeed;
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(distance * Vector3.forward);
            transform.Translate(distance * _liftForce * Vector3.up);
        }
        else
        {
            transform.Translate(_gravityForce * Vector3.up);
            transform.Translate(distance * Vector3.forward);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Fly();
    }
}
