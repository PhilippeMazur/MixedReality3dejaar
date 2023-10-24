using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public string sceneName = "PhilippeScene";  // The name of the scene to load

    // This function is called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided and loading scene");
        LoadScene();
    }

    // Load the specified scene
    private void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
