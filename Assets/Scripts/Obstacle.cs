using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player collided with obstacle");
        collisionCount++;
    }
    public int GetCollisionCount()
    {
        return collisionCount;
    }
}
