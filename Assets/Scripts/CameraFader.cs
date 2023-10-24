using System.Collections;
using UnityEngine;

public class CameraFader : MonoBehaviour
{
    public float fadeDuration = 2.0f; // Duration of the fade effect in seconds
    public Color fadeColor = Color.black; // Color to fade to (black in this case)

    private Camera mainCamera;
    private bool isFading = false;

    private void Start()
    {
        mainCamera = this.gameObject.GetComponent<Camera>();
    }

    public void TriggerFade()
    {
        if (!isFading)
        {
            StartCoroutine(FadeCamera());
        }
    }

    private IEnumerator FadeCamera()
    {
        isFading = true;
        float elapsedTime = 0f;
        Color initialColor = mainCamera.backgroundColor;

        while (elapsedTime < fadeDuration)
        {
            mainCamera.backgroundColor = Color.Lerp(initialColor, fadeColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.backgroundColor = fadeColor;
        yield return new WaitForSeconds(1.0f); // Wait for a moment with the screen completely black

        elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            mainCamera.backgroundColor = Color.Lerp(fadeColor, initialColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.backgroundColor = initialColor;
        isFading = false;
    }
}
