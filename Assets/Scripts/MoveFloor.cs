using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private GameObject planeObject; // Reference to the "Plane" object

    private void Start()
    {
        
    }
    public void destroyObject()
    {
        // Find the "Plane" object by name
        GameObject.Destroy(this.gameObject);
    }
}
