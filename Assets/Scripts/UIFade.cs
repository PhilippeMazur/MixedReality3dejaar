using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFade : MonoBehaviour
{
    private Image targetImage;
    private Color startColor = new Color(0, 0, 0, 255); 
    private Color endColor = new Color(0, 0, 0, 0);
    private bool aNiceLookingBoolean = false;
    float timer = 0f;
    private bool transitioned = false;


    void Start()
    {
        targetImage = this.gameObject.GetComponent<Image>();
        targetImage.color = endColor;

    }

    void Update()
    {

        if (aNiceLookingBoolean)
        {
            timer += Time.deltaTime; // Add the time elapsed since the last frame to the timer

            // Check if one second has passed
            if (timer >= 0.2f)
            {
                timer = 0f; // Reset the timer

                

                // Your other logic here
                if (!transitioned)
                {
                    targetImage.color += new Color(0, 0, 0, 20f); // Adjust the alpha value gradually
                    Debug.Log(targetImage.color);

                    if (targetImage.color.a >= 240f)
                    {
                        transitioned = true;
                        Debug.Log("going to reverse");
                    }

                }
                if(transitioned)
                {
                    Debug.Log("start reverse");
                    targetImage.color -= new Color(0, 0, 0, 50f); // Adjust the alpha value gradually
                    Debug.Log(targetImage.color);

                    if (targetImage.color.a <= 0)
                    {
                        aNiceLookingBoolean = false;
                        transitioned = false;
                    }
                }
            }
        }
    }

    public void StartFading()
    {
        aNiceLookingBoolean = true;
    }



    
}
