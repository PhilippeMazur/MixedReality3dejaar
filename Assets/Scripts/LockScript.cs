using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LockScript : MonoBehaviour
{
    private XRSocketInteractor socketInteractor;
    private bool isRotating = false;
    private float targetRotation = 90.0f;
    private float rotationSpeed = 90.0f; // Degrees per second
    private bool lockCompleted = false;
    private bool doorCompleted = false;
    public GameObject door;

    private void Start()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
        socketInteractor.onSelectEntered.AddListener(OnObjectPlaced);
    }

    private void Update()
    {
        float step = rotationSpeed * Time.deltaTime;

        if (isRotating)
        {
            transform.Rotate(Vector3.up * step);

            if (transform.rotation.eulerAngles.y <= targetRotation)
            {
                isRotating = false;
                Debug.Log("Rotation complete.");
                lockCompleted = true;
                Debug.Log(lockCompleted);
            }
        }

        if(lockCompleted && !doorCompleted)
        {
            Debug.Log("starting door moving");

            if(door.transform.position.z <= 18.28f)
            {
                Debug.Log("door is moving");
                door.transform.position += new Vector3(0, 0, 0.005f);
            } else
            {
                Debug.Log("door has been moved");
                doorCompleted = true;
                Debug.Log(door.transform.position.z);
            }
            
        }
    }

    private void OnObjectPlaced(XRBaseInteractable interactable)
    {
        if (!isRotating)
        {
            isRotating = true;
            Debug.Log("Object placed on the socket. Starting rotation.");
        }
    }
}
