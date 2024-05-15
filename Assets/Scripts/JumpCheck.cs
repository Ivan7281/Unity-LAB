using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    public float raycastDistance = 1f;

    public bool CanJump()
    {
        Vector3 raycastOrigin = transform.position;
        Vector3 raycastDirection = Vector3.down;

        RaycastHit hit;
        if (Physics.Raycast(raycastOrigin, raycastDirection, out hit, raycastDistance))
        {
            if (hit.collider != null)
            {
                return true;
            }
        }
        return false;
    }
}
