using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public bool IsOnGround = true;
    private void OnTriggerEnter(Collider other)
    {
        IsOnGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsOnGround = false;
    }
}
