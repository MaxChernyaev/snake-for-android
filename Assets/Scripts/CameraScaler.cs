using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScaler : MonoBehaviour
{
    [SerializeField] private float targetWidth = 10f; // Ширина сцены, которую нужно уместить в экран

    void Start()
    {
        Camera cam = Camera.main;
        float screenAspect = (float)Screen.width / Screen.height; // Текущее соотношение сторон экрана
        float targetOrthoSize = targetWidth / (2f * screenAspect);
        cam.orthographicSize = targetOrthoSize;
    }
}
