using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDistance : MonoBehaviour
{
    [SerializeField] private Text distanceText;
    public Transform playerTransform;
    public Transform finishTransform;
    void Start()
    {
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, finishTransform.position);
        distanceText.text = "Distance: " + distance.ToString("F1") + " M";
    }
}
