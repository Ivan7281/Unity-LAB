using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuCollided : MonoBehaviour
{
    public Text collisionCountText;

    // Update is called once per frame
    void Update()
    {
        if (collisionCountText != null)
        {
            Obstacle[] obstacles = FindObjectsOfType<Obstacle>();
            int totalCollisions = 0;

            foreach (Obstacle obstacle in obstacles)
            {
                totalCollisions += obstacle.GetCollisionCount();
            }

            collisionCountText.text = "Collisions: " + totalCollisions.ToString();
        }
    }
}
