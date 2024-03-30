using System.Collections;
using System.Collections.Generic;
using static Models;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerSettingsModel settings;
    private Vector3 targetRotation;



    private void Update () {
 
        CameraRotation();
    }

    private void CameraRotation() {
        var lookInput = playerController.look;

        targetRotation.x += (settings.InvertedY ? (lookInput.y * settings.SensitivityY) : -(lookInput.y * settings.SensitivityY)) * Time.deltaTime;
        targetRotation.y += (settings.InvertedX ? (lookInput.x * settings.SensitivityX) : -(lookInput.x * settings.SensitivityX)) * Time.deltaTime;

        targetRotation.x = Mathf.Clamp(targetRotation.x, settings.yClampMin, settings.yClampMax);

        transform.rotation = Quaternion.Euler(targetRotation);

        if (playerController.aimPos) {
            var currentRotation = playerController.transform.rotation.eulerAngles;
            currentRotation.y = targetRotation.y;

            
            playerController.transform.rotation = Quaternion.Euler(currentRotation);

        }
    }

}
