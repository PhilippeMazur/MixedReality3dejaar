using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public float amplitude = 0.2f; // Maximum height
    public float frequency = 0.2f; // Speed of oscillation

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPosition.x, startPosition.y + newY, startPosition.z);
    }
}
