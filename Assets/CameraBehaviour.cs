using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
   public Camera[] cameras; // Array to hold references to your cameras
    private int currentCameraIndex = 0; // Index of the currently active camera

    void Start()
    {
        // Disable all cameras except the first one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Check for input to switch cameras
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Disable the currently active camera
            cameras[currentCameraIndex].gameObject.SetActive(false);

            // Move to the next camera
            currentCameraIndex++;
            if (currentCameraIndex >= cameras.Length)
            {
                currentCameraIndex = 0;
            }

            // Enable the new active camera
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
    }
}
