using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Adjust the speed as needed

    void Update()
    {
        while(transform.position.z > 13.764)
        {
            transform.position += new Vector3(0, 0, 0.005f);
        }
    }
}
