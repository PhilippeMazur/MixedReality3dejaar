using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public float rotationSpeed = -12f;
    public float rotationDuration = 3f;
    public GameObject chestCover;
    public Animator animationComponent;
    private void OnTriggerEnter(Collider other)
    {
        animationComponent = chestCover.GetComponent<Animator>();
        animationComponent.enabled = true;
        animationComponent.SetTrigger("naam");
    }
}
